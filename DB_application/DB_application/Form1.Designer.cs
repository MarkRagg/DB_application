
namespace DB_application
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoAnimaleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listGabbia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.listCartelleCliniche = new System.Windows.Forms.ComboBox();
            this.listVaccini = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.descrizioneSintomi = new System.Windows.Forms.TextBox();
            this.listCodiceFiscale = new System.Windows.Forms.ComboBox();
            this.listCartelleCliniche_tab4 = new System.Windows.Forms.ComboBox();
            this.TimePicker_tab4 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listCodiceGabbia = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.animaliGabbiaView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listCodiciFiscaliDip = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.turniView = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listCartelleClinicheViewTab3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intolleranzeView = new System.Windows.Forms.DataGridView();
            this.altroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaliDataSet = new DB_application.animaliDataSet();
            this.altroTableAdapter = new DB_application.animaliDataSetTableAdapters.altroTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animaliGabbiaView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turniView)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intolleranzeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaliDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserisci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoAnimaleTxt
            // 
            this.tipoAnimaleTxt.Location = new System.Drawing.Point(300, 110);
            this.tipoAnimaleTxt.Name = "tipoAnimaleTxt";
            this.tipoAnimaleTxt.Size = new System.Drawing.Size(221, 22);
            this.tipoAnimaleTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "tipoAnimale";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 515);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listGabbia);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tipoAnimaleTxt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inserimento altri animali";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listGabbia
            // 
            this.listGabbia.FormattingEnabled = true;
            this.listGabbia.Location = new System.Drawing.Point(300, 177);
            this.listGabbia.Name = "listGabbia";
            this.listGabbia.Size = new System.Drawing.Size(221, 24);
            this.listGabbia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gabbia";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.listCartelleCliniche);
            this.tabPage3.Controls.Add(this.listVaccini);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(873, 486);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Inserimento vaccinazioni";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(357, 303);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Data somministrazione";
            // 
            // listCartelleCliniche
            // 
            this.listCartelleCliniche.FormattingEnabled = true;
            this.listCartelleCliniche.Location = new System.Drawing.Point(357, 216);
            this.listCartelleCliniche.Name = "listCartelleCliniche";
            this.listCartelleCliniche.Size = new System.Drawing.Size(240, 24);
            this.listCartelleCliniche.TabIndex = 4;
            // 
            // listVaccini
            // 
            this.listVaccini.FormattingEnabled = true;
            this.listVaccini.Location = new System.Drawing.Point(357, 138);
            this.listVaccini.Name = "listVaccini";
            this.listVaccini.Size = new System.Drawing.Size(240, 24);
            this.listVaccini.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cartella clinica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vaccino";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Inserimento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.descrizioneSintomi);
            this.tabPage4.Controls.Add(this.listCodiceFiscale);
            this.tabPage4.Controls.Add(this.listCartelleCliniche_tab4);
            this.tabPage4.Controls.Add(this.TimePicker_tab4);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(873, 486);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Inserimento visite";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // descrizioneSintomi
            // 
            this.descrizioneSintomi.Location = new System.Drawing.Point(374, 153);
            this.descrizioneSintomi.Name = "descrizioneSintomi";
            this.descrizioneSintomi.Size = new System.Drawing.Size(243, 22);
            this.descrizioneSintomi.TabIndex = 8;
            // 
            // listCodiceFiscale
            // 
            this.listCodiceFiscale.FormattingEnabled = true;
            this.listCodiceFiscale.Location = new System.Drawing.Point(374, 86);
            this.listCodiceFiscale.Name = "listCodiceFiscale";
            this.listCodiceFiscale.Size = new System.Drawing.Size(243, 24);
            this.listCodiceFiscale.TabIndex = 7;
            // 
            // listCartelleCliniche_tab4
            // 
            this.listCartelleCliniche_tab4.FormattingEnabled = true;
            this.listCartelleCliniche_tab4.Location = new System.Drawing.Point(374, 280);
            this.listCartelleCliniche_tab4.Name = "listCartelleCliniche_tab4";
            this.listCartelleCliniche_tab4.Size = new System.Drawing.Size(243, 24);
            this.listCartelleCliniche_tab4.TabIndex = 6;
            // 
            // TimePicker_tab4
            // 
            this.TimePicker_tab4.Location = new System.Drawing.Point(374, 214);
            this.TimePicker_tab4.Name = "TimePicker_tab4";
            this.TimePicker_tab4.Size = new System.Drawing.Size(243, 22);
            this.TimePicker_tab4.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(148, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Codice cartella";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Data visita";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descrizione sintomi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Codice fiscale veterinario";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Inserimento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listCodiceGabbia);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.animaliGabbiaView);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(873, 486);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "VisualizzaGabbia";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listCodiceGabbia
            // 
            this.listCodiceGabbia.FormattingEnabled = true;
            this.listCodiceGabbia.Location = new System.Drawing.Point(373, 268);
            this.listCodiceGabbia.Name = "listCodiceGabbia";
            this.listCodiceGabbia.Size = new System.Drawing.Size(88, 24);
            this.listCodiceGabbia.TabIndex = 2;
            this.listCodiceGabbia.SelectedIndexChanged += new System.EventHandler(this.listCodiceGabbia_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(185, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Codice gabbia";
            // 
            // animaliGabbiaView
            // 
            this.animaliGabbiaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaliGabbiaView.Location = new System.Drawing.Point(0, 0);
            this.animaliGabbiaView.Name = "animaliGabbiaView";
            this.animaliGabbiaView.RowHeadersWidth = 51;
            this.animaliGabbiaView.RowTemplate.Height = 24;
            this.animaliGabbiaView.Size = new System.Drawing.Size(877, 172);
            this.animaliGabbiaView.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listCodiciFiscaliDip);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.turniView);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(873, 486);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "VisualizzaTurni";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listCodiciFiscaliDip
            // 
            this.listCodiciFiscaliDip.FormattingEnabled = true;
            this.listCodiciFiscaliDip.Location = new System.Drawing.Point(387, 373);
            this.listCodiciFiscaliDip.Name = "listCodiciFiscaliDip";
            this.listCodiciFiscaliDip.Size = new System.Drawing.Size(247, 24);
            this.listCodiciFiscaliDip.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(236, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Dipendente";
            // 
            // turniView
            // 
            this.turniView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turniView.Location = new System.Drawing.Point(-4, 0);
            this.turniView.Name = "turniView";
            this.turniView.RowHeadersWidth = 51;
            this.turniView.RowTemplate.Height = 24;
            this.turniView.Size = new System.Drawing.Size(881, 300);
            this.turniView.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listCartelleClinicheViewTab3);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.intolleranzeView);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(873, 486);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Visualizza Intolleranze";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // listCartelleClinicheViewTab3
            // 
            this.listCartelleClinicheViewTab3.FormattingEnabled = true;
            this.listCartelleClinicheViewTab3.Location = new System.Drawing.Point(344, 336);
            this.listCartelleClinicheViewTab3.Name = "listCartelleClinicheViewTab3";
            this.listCartelleClinicheViewTab3.Size = new System.Drawing.Size(209, 24);
            this.listCartelleClinicheViewTab3.TabIndex = 2;
            this.listCartelleClinicheViewTab3.SelectedIndexChanged += new System.EventHandler(this.listCartelleClinicheViewTab3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codice cartella";
            // 
            // intolleranzeView
            // 
            this.intolleranzeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intolleranzeView.Location = new System.Drawing.Point(-4, 0);
            this.intolleranzeView.Name = "intolleranzeView";
            this.intolleranzeView.RowHeadersWidth = 51;
            this.intolleranzeView.RowTemplate.Height = 24;
            this.intolleranzeView.Size = new System.Drawing.Size(881, 243);
            this.intolleranzeView.TabIndex = 0;
            // 
            // altroBindingSource
            // 
            this.altroBindingSource.DataMember = "altro";
            this.altroBindingSource.DataSource = this.animaliDataSet;
            // 
            // animaliDataSet
            // 
            this.animaliDataSet.DataSetName = "animaliDataSet";
            this.animaliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // altroTableAdapter
            // 
            this.altroTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animaliGabbiaView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turniView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intolleranzeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaliDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tipoAnimaleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listGabbia;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox listCartelleCliniche;
        private System.Windows.Forms.ComboBox listVaccini;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox listCodiceFiscale;
        private System.Windows.Forms.ComboBox listCartelleCliniche_tab4;
        private System.Windows.Forms.DateTimePicker TimePicker_tab4;
        private System.Windows.Forms.TextBox descrizioneSintomi;
        private System.Windows.Forms.TabPage tabPage5;
        private animaliDataSet animaliDataSet;
        private System.Windows.Forms.BindingSource altroBindingSource;
        private animaliDataSetTableAdapters.altroTableAdapter altroTableAdapter;
        private System.Windows.Forms.DataGridView animaliGabbiaView;
        private System.Windows.Forms.ComboBox listCodiceGabbia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox listCodiciFiscaliDip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView turniView;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ComboBox listCartelleClinicheViewTab3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView intolleranzeView;
    }
}

