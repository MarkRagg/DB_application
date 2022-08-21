using AnimaliContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadOrRefresh();
        }

        private void loadOrRefresh()
        {
            addAllGabbias();
            addAllItemsTab3();
            addAllItemsTab4();
            addAllItemsTabView1();
            addAllItemsTabView2();
            fillAnimal();
            fillTurni();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var medicalRecords = new CartellaClinica();
                var codMedicalRecord = ctx.CartellaClinicas.Max(x => x.CodiceCartella) + 1;
                var codAnimal = ctx.Altros.Max(x => x.CodiceAnimale) + 1;
                var animal = new Altro();

                medicalRecords.CodiceCartella = codMedicalRecord;

                ctx.CartellaClinicas.InsertOnSubmit(medicalRecords);
                
                animal.TipoAnimale = tipoAnimaleTxt.Text;
                animal.CodiceGabbia = Convert.ToInt32(listGabbia.SelectedItem);
                animal.CodiceAnimale = codAnimal;
                animal.CodiceCartella = codMedicalRecord;

                ctx.Altros.InsertOnSubmit(animal);
                ctx.SubmitChanges();
                loadOrRefresh();
            }

            MessageBox.Show("Inserimento completato");
        }

        private void addAllGabbias()
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var list = ctx.Gabbias.Select(x => x.CodiceGabbia).ToList();
                list.ForEach(x => listGabbia.Items.Add(x));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                //Bisogna dividere l'operazione in: adozione cane e adozione animale
                var adoptionDate = dateTimePicker1.Value;
                //var adoption = ;
                //ctx.Altros.InsertOnSubmit();
                ctx.SubmitChanges();
            }

            MessageBox.Show("Inserimento completato");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var execution = new Esecuzione();
                var codVaccino = ctx.Vaccinos.Where(x => x.Descrizione.Equals(listVaccini.SelectedItem));
                execution.CodiceCartella = Convert.ToInt32(listCartelleCliniche.SelectedItem);
                execution.CodiceVaccino = codVaccino.First().CodiceVaccino;
                execution.DataSomministrazione = dateTimePicker2.Value;

                ctx.Esecuziones.InsertOnSubmit(execution);
                ctx.SubmitChanges();
                loadOrRefresh();
            }

            MessageBox.Show("Inserimento completato");
        }

        private void addAllItemsTab3()
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var itemsVaccini = ctx.Vaccinos.Select(x => x.Descrizione).ToList();
                var itemsCodCartelle = ctx.CartellaClinicas.Select(x => x.CodiceCartella).ToList();
                itemsVaccini.ForEach(x => listVaccini.Items.Add(x));
                itemsCodCartelle.ForEach(x => listCartelleCliniche.Items.Add(x));

                listVaccini.SelectedItem = itemsVaccini.First();
                listCartelleCliniche.SelectedItem = itemsCodCartelle.First();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {

                var codVisita = ctx.VisitaMedicas.Count() == 0 ? 
                    0 : 
                    ctx.VisitaMedicas.Max(x => x.CodiceVisita) + 1;
                var visitaMedica = new VisitaMedica();
                var veterinario = ctx.Personas.Where(x => x.Veterinario.Equals(listCodiceFiscale.SelectedItem)).ToList().First();

                veterinario.NumeroVisite += 1;
                visitaMedica.CodiceCartella = Convert.ToInt32(listCartelleCliniche_tab4.SelectedItem);
                visitaMedica.CodiceFiscale = veterinario.CodiceFiscale;
                visitaMedica.DescrizioneSintomi = descrizioneSintomi.Text;
                visitaMedica.DataVisita = TimePicker_tab4.Value;
                visitaMedica.CodiceVisita = codVisita;

                ctx.VisitaMedicas.InsertOnSubmit(visitaMedica);
                ctx.Personas.GetModifiedMembers(veterinario);
                ctx.SubmitChanges();
                loadOrRefresh();
            }

            MessageBox.Show("Inserimento completato");
        }

        private void addAllItemsTab4()
        {
            {
                using (AnimaliDataContext ctx = new AnimaliDataContext())
                {
                    var itemsCartelle = ctx.CartellaClinicas.Select(x => x.CodiceCartella).ToList();
                    var itemsCodiciFiscali = ctx.Personas.Where(x => !x.Veterinario.Equals("")).ToList();
                    itemsCartelle.ForEach(x => listCartelleCliniche_tab4.Items.Add(x));
                    itemsCodiciFiscali.ForEach(x => listCodiceFiscale.Items.Add(x.Veterinario));

                    listCartelleCliniche_tab4.SelectedItem = itemsCartelle.First();
                    listCodiceFiscale.SelectedItem = itemsCodiciFiscali.First();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            fillAnimal();
            fillTurni();
        }

        private void fillAnimal()
        {
            showTelephoneNumberOnGrid(1);
            animaliGabbiaView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            animaliGabbiaView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showTelephoneNumberOnGrid(int codiceGabbia)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var numeroAnimaliInGabbia = ctx.Altros.Where(x => x.CodiceGabbia == codiceGabbia).Count();
                var query = ctx.Gabbias.Where(x => x.CodiceGabbia == codiceGabbia)
                                       .Select(g => new
                                            {
                                            codiceGabbia = g.CodiceGabbia,
                                            lunghezza = g.Lunghezza,
                                            larghezza = g.Larghezza,
                                            numeroAnimali = numeroAnimaliInGabbia
                                       });
                ShowResultsOnGrid(query, animaliGabbiaView);
            }
        }

        private void ShowResultsOnGrid(IQueryable queryResult, DataGridView dataGrid)
        {
            try
            {
                dataGrid.DataSource = queryResult;
            }
            catch (InvalidOperationException)
            {
            }
        }

        private void addAllItemsTabView1()
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var itemsCodiceGabbia = ctx.Gabbias.Select(x => x.CodiceGabbia).ToList();
                itemsCodiceGabbia.ForEach(x => listCodiceGabbia.Items.Add(x));
                listCodiceGabbia.SelectedItem = itemsCodiceGabbia.First();
            }
        }

        private void listCodiceGabbia_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTelephoneNumberOnGrid(Convert.ToInt32(listCodiceGabbia.SelectedItem));
        }

        private void addAllItemsTabView2()
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var itemsCodiciFiscali = ctx.Personas.Where(x => x.Dipendente != "")
                                                     .Select(x => x.CodiceFiscale).ToList();
                itemsCodiciFiscali.ForEach(x => listCodiciFiscaliDip.Items.Add(x));
                listCodiciFiscaliDip.SelectedItem = itemsCodiciFiscali.First();
            }
        }

        private void fillTurni()
        {
            showTurniDiLavoroOnGrid(Convert.ToString(listCodiciFiscaliDip.SelectedItem));
            turniView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            turniView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showTurniDiLavoroOnGrid(string codiceFiscale)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var query = from p in ctx.Personas
                            join t in ctx.TurnoDiLavoros on p.CodiceFiscale equals t.CodiceFiscale
                            where p.Dipendente != ""
                            select new
                            {
                                nome = p.Nome,
                                cognome = p.Cognome,
                                telefono = p.Telefono,
                                orarioInizio = t.OraInizio.Hour,
                                orarioFine = t.OraFine.Hour,
                                mese = t.Mese,
                                anno = t.Anno
                            };
                ShowResultsOnGrid(query, turniView);
            }
        }
    }
}
