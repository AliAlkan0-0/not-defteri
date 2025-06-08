using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        public class Not
        {
            public string Icerik { get; set; }
            public string Kategori { get; set; }
        }

        
        private List<Not> notlar = new List<Not>();
        private string dosyaYolu = "notlar.json";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                notlar = JsonConvert.DeserializeObject<List<Not>>(json) ?? new List<Not>();

                var kategoriler = notlar.Select(n => n.Kategori).Distinct().ToList();
                comboBox1.Items.AddRange(kategoriler.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string icerik = textBox1.Text;
            string kategori = comboBox1.SelectedItem?.ToString() ?? "Kategorisiz";

            Not yeniNot = new Not { Icerik = icerik, Kategori = kategori };
            notlar.Add(yeniNot);

            string json = JsonConvert.SerializeObject(notlar, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(dosyaYolu, json);

            MessageBox.Show("Not kaydedildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yeniKategori = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(yeniKategori) && !comboBox1.Items.Contains(yeniKategori))
            {
                comboBox1.Items.Add(yeniKategori);
                textBox2.Clear();
                MessageBox.Show("Kategori eklendi.");

               
                List<string> kategoriler = comboBox1.Items.Cast<string>().ToList();

               
                string json = JsonConvert.SerializeObject(kategoriler, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("kategoriler.json", json);
            }
            else
            {
                MessageBox.Show("Geçerli bir kategori girin.");
            }
        }
    }
}
    