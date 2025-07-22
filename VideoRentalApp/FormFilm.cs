// Refactor: FormFilm.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VideoRentalApp
{
    public partial class FormFilm : Form
    {
        public FormFilm()
        {
            InitializeComponent();
            this.Load += FormFilm_Load;
            buttonAdauga.Click += buttonAdauga_Click;
            buttonSterge.Click += buttonSterge_Click;
            buttonEditeaza.Click += buttonEditeaza_Click;
            listBoxFilme.SelectedIndexChanged += ListBoxFilme_SelectedIndexChanged;
        }

        private void FormFilm_Load(object sender, EventArgs e) => AfiseazaFilme();

        private void AfiseazaFilme()
        {
            listBoxFilme.Items.Clear();

            string query = "SELECT * FROM Filme";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Film f = new Film
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Titlu = row["Titlu"].ToString(),
                    Gen = row["Gen"].ToString()
                };
                listBoxFilme.Items.Add(f);
            }
        }


        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string titlu = textBoxTitlu.Text.Trim();
            string gen = textBoxGen.Text.Trim();

            if (string.IsNullOrWhiteSpace(titlu) || string.IsNullOrWhiteSpace(gen))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            string query = "INSERT INTO Filme (Titlu, Gen) VALUES (@Titlu, @Gen)";
            var parameters = new Dictionary<string, object>
    {
        {"@Titlu", titlu},
        {"@Gen", gen}
    };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaFilme();
            textBoxTitlu.Clear();
            textBoxGen.Clear();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (listBoxFilme.SelectedItem == null)
            {
                MessageBox.Show("Selectează un film!");
                return;
            }

            var film = (Film)listBoxFilme.SelectedItem;

            string query = "DELETE FROM Filme WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
    {
        {"@Id", film.Id}
    };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaFilme();
        }

        private void buttonEditeaza_Click(object sender, EventArgs e)
        {
            if (listBoxFilme.SelectedItem == null)
            {
                MessageBox.Show("Selectează un film!");
                return;
            }

            var film = (Film)listBoxFilme.SelectedItem;
            string titlu = textBoxTitlu.Text.Trim();
            string gen = textBoxGen.Text.Trim();

            if (string.IsNullOrWhiteSpace(titlu) || string.IsNullOrWhiteSpace(gen))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            string query = "UPDATE Filme SET Titlu = @Titlu, Gen = @Gen WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
    {
        {"@Titlu", titlu},
        {"@Gen", gen},
        {"@Id", film.Id}
    };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaFilme();
        }

        private void ListBoxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilme.SelectedItem is Film film)
            {
                textBoxTitlu.Text = film.Titlu;
                textBoxGen.Text = film.Gen;
            }
        }
    }
}
