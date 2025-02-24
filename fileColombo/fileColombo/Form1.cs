using Newtonsoft.Json;

namespace fileColombo
{
    public partial class Form1 : Form
    {
        List<Persona> persone;
        private const int RecordLength = 70; // Lunghezza fissa per ogni record

        public Form1()
        {
            InitializeComponent();
            persone = new List<Persona>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            caricaPersoneDaFile("ListaPersone");
        }

        private void caricaPersoneDaFile(string filename)
        {
            listBox1.Items.Clear();
            persone.Clear();
            if (File.Exists(filename))
            {
                var lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    listBox1.Items.Add(line);
                    var parts = line.Split(';');
                    if (parts.Length >= 3)
                    {
                        string id = parts[0].Trim();
                        string surname = parts[1].Trim();
                        string name = parts[2].Trim();
                        persone.Add(new Persona(id, surname, name));
                    }
                }
            }
        }

        private void aggiungi_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
                return;

            string id = textBox1.Text;
            if (persone.Any(p => p.Id == id))
            {
                MessageBox.Show("Errore: ID già esistente.");
                return;
            }

            Persona persona = new Persona(id, textBox2.Text, textBox3.Text);
            scriviAppend("ListaPersone", PersonaToString(persona));
            persone.Add(persona);
            listBox1.Items.Add(PersonaToString(persona));
        }

        private void cerca_btn_Click(object sender, EventArgs e)
        {
            string idDaCercare = textBox1.Text;
            string risultato = cercaPersonaPerId(idDaCercare);
            MessageBox.Show(risultato != null ? $"Persona trovata: {risultato}" : "Persona non trovata.");
        }

        private string cercaPersonaPerId(string id)
        {
            return persone.FirstOrDefault(p => p.Id == id)?.ToString();
        }

        private void elimina_btn_Click(object sender, EventArgs e)
        {
            string idDaEliminare = textBox1.Text;
            if (!persone.Any(p => p.Id == idDaEliminare))
            {
                MessageBox.Show("Errore: ID non trovato.");
                return;
            }

            persone.RemoveAll(p => p.Id == idDaEliminare);
            File.WriteAllLines("ListaPersone", persone.Select(p => PersonaToString(p)));
            caricaPersoneDaFile("ListaPersone");
        }

        private void modifica_btn_Click(object sender, EventArgs e)
        {
            string idDaModificare = textBox1.Text;
            string nuovoCognome = textBox2.Text;
            string nuovoNome = textBox3.Text;

            var persona = persone.FirstOrDefault(p => p.Id == idDaModificare);
            if (persona != null)
            {
                persona.Surname = nuovoCognome;
                persona.Name = nuovoNome;
                File.WriteAllLines("ListaPersone", persone.Select(p => PersonaToString(p)));
                caricaPersoneDaFile("ListaPersone");
            }
        }

        public static void scriviAppend(string filename, string content)
        {
            using (var sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(content);
            }
        }

        private void cercaRiga_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int riga) && riga > 0)
            {
                string risultato = accessoDirettoRiga("ListaPersone", riga, RecordLength)?.Trim('-');
                MessageBox.Show(!string.IsNullOrWhiteSpace(risultato) ? $"Record trovato: {risultato}" : "Riga non trovata.");
            }
            else
            {
                MessageBox.Show("Inserisci un numero di riga valido.");
            }
        }

        private string PersonaToString(Persona persona)
        {
            string record = $"{persona.Id};{persona.Surname};{persona.Name}".PadRight(RecordLength, '-');
            return record.Substring(0, RecordLength);
        }


        //gestione di file binari fixed lenght e accesso diretto
        public static string accessoDirettoRiga(string filename, int i, int bytesPerLine)
        {
            Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            stream.Seek(bytesPerLine * (i - 1), SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);

            char[] buffer = new char[bytesPerLine];
            reader.Read(buffer, 0, bytesPerLine);
            string line = new string(buffer).Trim('-').Trim();

            // Chiude esplicitamente il reader e il file stream
            reader.Close();
            stream.Close();

            return line;
        }
    }
}
