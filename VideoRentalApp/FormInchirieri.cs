using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VideoRentalApp
{
    public partial class FormInchirieri : Form
    {
        public FormInchirieri()
        {
            InitializeComponent();
            this.Load += FormInchirieri_Load;
            buttonAdauga.Click += buttonAdauga_Click;
        }

        private void FormInchirieri_Load(object sender, EventArgs e)
        {
            AfiseazaInchirieri();
        }

        private void AfiseazaInchirieri()
        {
            listBoxInchirieri.Items.Clear();

            string query = @"
                SELECT i.Id, c.Nume AS ClientNume, f.Titlu AS FilmTitlu, i.DataInchiriere, i.DataReturnare
                FROM Inchirieri i
                JOIN Clienti c ON c.Id = i.ClientId
                JOIN Filme f ON f.Id = i.FilmId";

            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string item = $"{row["ClientNume"]} - {row["FilmTitlu"]} | {Convert.ToDateTime(row["DataInchiriere"]).ToShortDateString()}";

                if (row["DataReturnare"] != DBNull.Value)
                    item += $" → returnat: {Convert.ToDateTime(row["DataReturnare"]).ToShortDateString()}";

                listBoxInchirieri.Items.Add(item);
            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string numeClient = textBoxClienti.Text.Trim();
            string titluFilm = textBoxTitlu.Text.Trim();
            string genFilm = textBoxGen.Text.Trim();
            DateTime dataIn = dateInchiriere.Value;
            DateTime? dataRet = dateReturnare.Checked ? dateReturnare.Value : (DateTime?)null;

            if (string.IsNullOrEmpty(numeClient) || string.IsNullOrEmpty(titluFilm) || string.IsNullOrEmpty(genFilm))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            // Caută sau inserează Client
            int clientId = DbHelper.GetOrInsertClient(numeClient);

            // Caută sau inserează Film
            int filmId = DbHelper.GetOrInsertFilm(titluFilm, genFilm);

            // Adaugă închiriere
            string query = @"
                INSERT INTO Inchirieri (ClientId, FilmId, DataInchiriere, DataReturnare)
                VALUES (@ClientId, @FilmId, @DataInchiriere, @DataReturnare)";

            var parameters = new Dictionary<string, object>
            {
                { "@ClientId", clientId },
                { "@FilmId", filmId },
                { "@DataInchiriere", dataIn },
                { "@DataReturnare", dataRet.HasValue ? (object)dataRet.Value : DBNull.Value }
                //pt C# 7.3
            };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaInchirieri();

            textBoxClienti.Clear();
            textBoxTitlu.Clear();
            textBoxGen.Clear();
        }
    }
 }