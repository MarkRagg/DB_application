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
    }
}
