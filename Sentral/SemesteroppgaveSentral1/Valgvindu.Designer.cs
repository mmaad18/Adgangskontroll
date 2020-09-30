namespace SemesteroppgaveSentral1
{
    partial class Valgvindu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.faneRedigering = new System.Windows.Forms.TabPage();
            this.buttonAvbryt = new System.Windows.Forms.Button();
            this.textEtternavn = new System.Windows.Forms.TextBox();
            this.textFornavn = new System.Windows.Forms.TextBox();
            this.textTilÅr = new System.Windows.Forms.TextBox();
            this.textFraDag = new System.Windows.Forms.TextBox();
            this.textFraÅr = new System.Windows.Forms.TextBox();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.textEpost = new System.Windows.Forms.TextBox();
            this.textFraMåned = new System.Windows.Forms.TextBox();
            this.textTilDag = new System.Windows.Forms.TextBox();
            this.textTilMåned = new System.Windows.Forms.TextBox();
            this.textKortID = new System.Windows.Forms.TextBox();
            this.buttonLagre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelEtternavn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFornavn = new System.Windows.Forms.Label();
            this.labelKortID = new System.Windows.Forms.Label();
            this.labelEpost = new System.Windows.Forms.Label();
            this.faneBrukere = new System.Windows.Forms.TabPage();
            this.Valgliste = new System.Windows.Forms.ListBox();
            this.labelGyldihet = new System.Windows.Forms.Label();
            this.buttonSlett = new System.Windows.Forms.Button();
            this.textTilbakemelding = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAvslutt = new System.Windows.Forms.Button();
            this.faneKlienter = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.KortleserListe = new System.Windows.Forms.ListBox();
            this.faneVindu = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.faneRedigering.SuspendLayout();
            this.faneBrukere.SuspendLayout();
            this.faneKlienter.SuspendLayout();
            this.faneVindu.SuspendLayout();
            this.SuspendLayout();
            // 
            // faneRedigering
            // 
            this.faneRedigering.Controls.Add(this.buttonAvbryt);
            this.faneRedigering.Controls.Add(this.textEtternavn);
            this.faneRedigering.Controls.Add(this.textFornavn);
            this.faneRedigering.Controls.Add(this.textTilÅr);
            this.faneRedigering.Controls.Add(this.textFraDag);
            this.faneRedigering.Controls.Add(this.textFraÅr);
            this.faneRedigering.Controls.Add(this.textPIN);
            this.faneRedigering.Controls.Add(this.textEpost);
            this.faneRedigering.Controls.Add(this.textFraMåned);
            this.faneRedigering.Controls.Add(this.textTilDag);
            this.faneRedigering.Controls.Add(this.textTilMåned);
            this.faneRedigering.Controls.Add(this.textKortID);
            this.faneRedigering.Controls.Add(this.buttonLagre);
            this.faneRedigering.Controls.Add(this.label5);
            this.faneRedigering.Controls.Add(this.label6);
            this.faneRedigering.Controls.Add(this.label7);
            this.faneRedigering.Controls.Add(this.label8);
            this.faneRedigering.Controls.Add(this.label9);
            this.faneRedigering.Controls.Add(this.labelPIN);
            this.faneRedigering.Controls.Add(this.labelEtternavn);
            this.faneRedigering.Controls.Add(this.label10);
            this.faneRedigering.Controls.Add(this.labelFornavn);
            this.faneRedigering.Controls.Add(this.labelKortID);
            this.faneRedigering.Controls.Add(this.labelEpost);
            this.faneRedigering.Location = new System.Drawing.Point(4, 22);
            this.faneRedigering.Name = "faneRedigering";
            this.faneRedigering.Padding = new System.Windows.Forms.Padding(3);
            this.faneRedigering.Size = new System.Drawing.Size(669, 344);
            this.faneRedigering.TabIndex = 1;
            this.faneRedigering.Text = "Endre Bruker";
            this.faneRedigering.UseVisualStyleBackColor = true;
            this.faneRedigering.Enter += new System.EventHandler(this.faneRedigering_Enter);
            // 
            // buttonAvbryt
            // 
            this.buttonAvbryt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvbryt.Location = new System.Drawing.Point(459, 264);
            this.buttonAvbryt.Name = "buttonAvbryt";
            this.buttonAvbryt.Size = new System.Drawing.Size(104, 39);
            this.buttonAvbryt.TabIndex = 61;
            this.buttonAvbryt.Text = "Avbryt";
            this.buttonAvbryt.UseVisualStyleBackColor = true;
            this.buttonAvbryt.Click += new System.EventHandler(this.buttonAvbryt_Click);
            // 
            // textEtternavn
            // 
            this.textEtternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEtternavn.Location = new System.Drawing.Point(217, 32);
            this.textEtternavn.MaxLength = 100;
            this.textEtternavn.Name = "textEtternavn";
            this.textEtternavn.Size = new System.Drawing.Size(346, 29);
            this.textEtternavn.TabIndex = 38;
            // 
            // textFornavn
            // 
            this.textFornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFornavn.Location = new System.Drawing.Point(217, 67);
            this.textFornavn.MaxLength = 100;
            this.textFornavn.Name = "textFornavn";
            this.textFornavn.Size = new System.Drawing.Size(346, 29);
            this.textFornavn.TabIndex = 39;
            // 
            // textTilÅr
            // 
            this.textTilÅr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTilÅr.Location = new System.Drawing.Point(514, 172);
            this.textTilÅr.MaxLength = 4;
            this.textTilÅr.Name = "textTilÅr";
            this.textTilÅr.Size = new System.Drawing.Size(49, 29);
            this.textTilÅr.TabIndex = 59;
            // 
            // textFraDag
            // 
            this.textFraDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFraDag.Location = new System.Drawing.Point(217, 172);
            this.textFraDag.MaxLength = 2;
            this.textFraDag.Name = "textFraDag";
            this.textFraDag.Size = new System.Drawing.Size(28, 29);
            this.textFraDag.TabIndex = 40;
            // 
            // textFraÅr
            // 
            this.textFraÅr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFraÅr.Location = new System.Drawing.Point(327, 172);
            this.textFraÅr.MaxLength = 4;
            this.textFraÅr.Name = "textFraÅr";
            this.textFraÅr.Size = new System.Drawing.Size(49, 29);
            this.textFraÅr.TabIndex = 58;
            // 
            // textPIN
            // 
            this.textPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPIN.Location = new System.Drawing.Point(217, 210);
            this.textPIN.MaxLength = 4;
            this.textPIN.Name = "textPIN";
            this.textPIN.Size = new System.Drawing.Size(49, 29);
            this.textPIN.TabIndex = 41;
            // 
            // textEpost
            // 
            this.textEpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEpost.Location = new System.Drawing.Point(217, 102);
            this.textEpost.MaxLength = 100;
            this.textEpost.Name = "textEpost";
            this.textEpost.Size = new System.Drawing.Size(346, 29);
            this.textEpost.TabIndex = 42;
            // 
            // textFraMåned
            // 
            this.textFraMåned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFraMåned.Location = new System.Drawing.Point(272, 172);
            this.textFraMåned.MaxLength = 2;
            this.textFraMåned.Name = "textFraMåned";
            this.textFraMåned.Size = new System.Drawing.Size(28, 29);
            this.textFraMåned.TabIndex = 43;
            // 
            // textTilDag
            // 
            this.textTilDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTilDag.Location = new System.Drawing.Point(404, 172);
            this.textTilDag.MaxLength = 2;
            this.textTilDag.Name = "textTilDag";
            this.textTilDag.Size = new System.Drawing.Size(28, 29);
            this.textTilDag.TabIndex = 44;
            // 
            // textTilMåned
            // 
            this.textTilMåned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTilMåned.Location = new System.Drawing.Point(459, 172);
            this.textTilMåned.MaxLength = 2;
            this.textTilMåned.Name = "textTilMåned";
            this.textTilMåned.Size = new System.Drawing.Size(28, 29);
            this.textTilMåned.TabIndex = 45;
            // 
            // textKortID
            // 
            this.textKortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKortID.Location = new System.Drawing.Point(217, 137);
            this.textKortID.MaxLength = 4;
            this.textKortID.Name = "textKortID";
            this.textKortID.Size = new System.Drawing.Size(49, 29);
            this.textKortID.TabIndex = 46;
            // 
            // buttonLagre
            // 
            this.buttonLagre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLagre.Location = new System.Drawing.Point(217, 264);
            this.buttonLagre.Name = "buttonLagre";
            this.buttonLagre.Size = new System.Drawing.Size(104, 39);
            this.buttonLagre.TabIndex = 60;
            this.buttonLagre.Text = "Lagre";
            this.buttonLagre.UseVisualStyleBackColor = true;
            this.buttonLagre.Click += new System.EventHandler(this.buttonLagre_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "/";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "/";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "/";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPIN.Location = new System.Drawing.Point(161, 210);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(50, 24);
            this.labelPIN.TabIndex = 52;
            this.labelPIN.Text = "PIN: ";
            this.labelPIN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEtternavn
            // 
            this.labelEtternavn.AutoSize = true;
            this.labelEtternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtternavn.Location = new System.Drawing.Point(112, 35);
            this.labelEtternavn.Name = "labelEtternavn";
            this.labelEtternavn.Size = new System.Drawing.Size(99, 24);
            this.labelEtternavn.TabIndex = 47;
            this.labelEtternavn.Text = "Etternavn: ";
            this.labelEtternavn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Gyldighetsperiode: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFornavn
            // 
            this.labelFornavn.AutoSize = true;
            this.labelFornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornavn.Location = new System.Drawing.Point(121, 70);
            this.labelFornavn.Name = "labelFornavn";
            this.labelFornavn.Size = new System.Drawing.Size(90, 24);
            this.labelFornavn.TabIndex = 48;
            this.labelFornavn.Text = "Fornavn: ";
            this.labelFornavn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelKortID
            // 
            this.labelKortID.AutoSize = true;
            this.labelKortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKortID.Location = new System.Drawing.Point(141, 140);
            this.labelKortID.Name = "labelKortID";
            this.labelKortID.Size = new System.Drawing.Size(70, 24);
            this.labelKortID.TabIndex = 50;
            this.labelKortID.Text = "KortID: ";
            this.labelKortID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEpost
            // 
            this.labelEpost.AutoSize = true;
            this.labelEpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpost.Location = new System.Drawing.Point(143, 105);
            this.labelEpost.Name = "labelEpost";
            this.labelEpost.Size = new System.Drawing.Size(68, 24);
            this.labelEpost.TabIndex = 49;
            this.labelEpost.Text = "Epost: ";
            this.labelEpost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // faneBrukere
            // 
            this.faneBrukere.Controls.Add(this.Valgliste);
            this.faneBrukere.Controls.Add(this.labelGyldihet);
            this.faneBrukere.Controls.Add(this.buttonSlett);
            this.faneBrukere.Location = new System.Drawing.Point(4, 22);
            this.faneBrukere.Name = "faneBrukere";
            this.faneBrukere.Padding = new System.Windows.Forms.Padding(3);
            this.faneBrukere.Size = new System.Drawing.Size(669, 344);
            this.faneBrukere.TabIndex = 0;
            this.faneBrukere.Text = "Brukerliste";
            this.faneBrukere.UseVisualStyleBackColor = true;
            this.faneBrukere.Enter += new System.EventHandler(this.faneBrukere_Enter);
            // 
            // Valgliste
            // 
            this.Valgliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valgliste.FormattingEnabled = true;
            this.Valgliste.ItemHeight = 24;
            this.Valgliste.Location = new System.Drawing.Point(6, 51);
            this.Valgliste.MultiColumn = true;
            this.Valgliste.Name = "Valgliste";
            this.Valgliste.Size = new System.Drawing.Size(657, 268);
            this.Valgliste.TabIndex = 40;
            this.Valgliste.SelectedIndexChanged += new System.EventHandler(this.Valgliste_SelectedIndexChanged);
            // 
            // labelGyldihet
            // 
            this.labelGyldihet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGyldihet.Location = new System.Drawing.Point(6, 3);
            this.labelGyldihet.Name = "labelGyldihet";
            this.labelGyldihet.Size = new System.Drawing.Size(282, 34);
            this.labelGyldihet.TabIndex = 38;
            this.labelGyldihet.Text = "Liste med registrerte brukere: ";
            // 
            // buttonSlett
            // 
            this.buttonSlett.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlett.Location = new System.Drawing.Point(512, 6);
            this.buttonSlett.Name = "buttonSlett";
            this.buttonSlett.Size = new System.Drawing.Size(151, 39);
            this.buttonSlett.TabIndex = 37;
            this.buttonSlett.Text = "Slett Bruker";
            this.buttonSlett.UseVisualStyleBackColor = true;
            this.buttonSlett.Click += new System.EventHandler(this.buttonSlett_Click);
            // 
            // textTilbakemelding
            // 
            this.textTilbakemelding.BackColor = System.Drawing.Color.White;
            this.textTilbakemelding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTilbakemelding.Location = new System.Drawing.Point(276, 388);
            this.textTilbakemelding.MaxLength = 100;
            this.textTilbakemelding.Name = "textTilbakemelding";
            this.textTilbakemelding.ReadOnly = true;
            this.textTilbakemelding.Size = new System.Drawing.Size(413, 29);
            this.textTilbakemelding.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tilbakemelding:";
            // 
            // buttonAvslutt
            // 
            this.buttonAvslutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvslutt.Location = new System.Drawing.Point(12, 388);
            this.buttonAvslutt.Name = "buttonAvslutt";
            this.buttonAvslutt.Size = new System.Drawing.Size(104, 39);
            this.buttonAvslutt.TabIndex = 39;
            this.buttonAvslutt.Text = "Avslutt";
            this.buttonAvslutt.UseVisualStyleBackColor = true;
            this.buttonAvslutt.Click += new System.EventHandler(this.buttonAvslutt_Click);
            // 
            // faneKlienter
            // 
            this.faneKlienter.Controls.Add(this.label2);
            this.faneKlienter.Controls.Add(this.KortleserListe);
            this.faneKlienter.Location = new System.Drawing.Point(4, 22);
            this.faneKlienter.Name = "faneKlienter";
            this.faneKlienter.Padding = new System.Windows.Forms.Padding(3);
            this.faneKlienter.Size = new System.Drawing.Size(669, 344);
            this.faneKlienter.TabIndex = 2;
            this.faneKlienter.Text = "Klienter";
            this.faneKlienter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Liste med tilkoblede kortlesere: ";
            // 
            // KortleserListe
            // 
            this.KortleserListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KortleserListe.FormattingEnabled = true;
            this.KortleserListe.ItemHeight = 24;
            this.KortleserListe.Location = new System.Drawing.Point(6, 40);
            this.KortleserListe.MultiColumn = true;
            this.KortleserListe.Name = "KortleserListe";
            this.KortleserListe.Size = new System.Drawing.Size(653, 292);
            this.KortleserListe.TabIndex = 36;
            // 
            // faneVindu
            // 
            this.faneVindu.Controls.Add(this.faneKlienter);
            this.faneVindu.Controls.Add(this.faneBrukere);
            this.faneVindu.Controls.Add(this.faneRedigering);
            this.faneVindu.Location = new System.Drawing.Point(12, 12);
            this.faneVindu.Name = "faneVindu";
            this.faneVindu.SelectedIndex = 0;
            this.faneVindu.Size = new System.Drawing.Size(677, 370);
            this.faneVindu.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Valgvindu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(711, 436);
            this.Controls.Add(this.textTilbakemelding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faneVindu);
            this.Controls.Add(this.buttonAvslutt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Valgvindu";
            this.Text = "Valgvindu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Valgvindu_FormClosing);
            this.faneRedigering.ResumeLayout(false);
            this.faneRedigering.PerformLayout();
            this.faneBrukere.ResumeLayout(false);
            this.faneKlienter.ResumeLayout(false);
            this.faneVindu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage faneRedigering;
        private System.Windows.Forms.Button buttonAvbryt;
        private System.Windows.Forms.TextBox textEtternavn;
        private System.Windows.Forms.TextBox textFornavn;
        private System.Windows.Forms.TextBox textTilÅr;
        private System.Windows.Forms.TextBox textFraDag;
        private System.Windows.Forms.TextBox textFraÅr;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.TextBox textEpost;
        private System.Windows.Forms.TextBox textFraMåned;
        private System.Windows.Forms.TextBox textTilDag;
        private System.Windows.Forms.TextBox textTilMåned;
        private System.Windows.Forms.TextBox textKortID;
        private System.Windows.Forms.Button buttonLagre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelEtternavn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFornavn;
        private System.Windows.Forms.Label labelKortID;
        private System.Windows.Forms.Label labelEpost;
        private System.Windows.Forms.TabPage faneBrukere;
        private System.Windows.Forms.TextBox textTilbakemelding;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox Valgliste;
        private System.Windows.Forms.Button buttonAvslutt;
        private System.Windows.Forms.Label labelGyldihet;
        private System.Windows.Forms.Button buttonSlett;
        private System.Windows.Forms.TabPage faneKlienter;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox KortleserListe;
        private System.Windows.Forms.TabControl faneVindu;
        private System.Windows.Forms.Timer timer1;

    }
}