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
            addAllGabbias();
            addAllItemsTab3();
            addAllItemsTab4();
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
    }
}
