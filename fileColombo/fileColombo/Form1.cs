using Newtonsoft.Json;

namespace fileColombo
{
    public partial class Form1 : Form
    {
        List<Persona> persone;
        public Form1()
        {
            InitializeComponent();
            persone = new List<Persona>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carica il contenuto del file nella ListBox al caricamento del form
            caricaPersoneDaFile("ListaPersone");
        }


        private void caricaPersoneDaFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {

                    listBox1.Items.Add(line);
                }
            }
        }


        private void aggiungi_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
                return;
            string caratteristiche;
            Persona persona = new Persona(textBox1.Text, textBox2.Text, textBox3.Text);

            caratteristiche = "ID: " + persona.Id + "   Cognome: " + persona.Surname + "   Nome: " + persona.Name;

            scriviAppend("ListaPersone", caratteristiche);
            persone.Add(persona);
            listBox1.Items.Add(caratteristiche);
        }

        private void cerca_btn_Click(object sender, EventArgs e)
        {
            string idDaCercare = textBox1.Text;
            string risultato = cercaPersonaPerId("ListaPersone", idDaCercare);

            if (risultato != null)
            {
                MessageBox.Show("Persona trovata: " + risultato);
            }
            else
            {
                MessageBox.Show("Persona con ID " + idDaCercare + " non trovata.");
            }
        }

        private string cercaPersonaPerId(string filename, string id)
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    // Verifica se la riga contiene l'ID
                    if (line.Contains("ID: " + id))
                    {
                        return line; // Restituisce la persona trovata
                    }
                }
            }
            return null; // Se la persona non è trovata
        }


        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }



        //leggere-scrviere oggetti in json
        // per altri esempi https://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
        public static void scriviOggettoPersona(string filename, Persona p)
        {

            string json = JsonConvert.SerializeObject(p);
            File.WriteAllText(filename, json);
        }

        public static Persona leggiOggettoPersona(string filename)
        {
            string json = File.ReadAllText(filename);
            Persona p = JsonConvert.DeserializeObject<Persona>(json);
            return p;
        }


        //gestione di file binari fixed lenght e accesso diretto
        public static string accessoDirettoRiga(string filename, int i, int bytesPerLine)
        {
            Stream stream = File.Open(filename, FileMode.Open);
            stream.Seek(bytesPerLine * (i - 1), SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            string line = reader.ReadLine();
            //BinaryReader rbin = new BinaryReader(stream);
            //string line = System.Text.Encoding.UTF8.GetString(rbin.ReadBytes(bytesPerLine));

            return line;
        }
    }
}
