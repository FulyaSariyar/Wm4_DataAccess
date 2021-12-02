namespace North_DbFirst
{
    partial class SiparisForm
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArtir = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cbmShippers = new System.Windows.Forms.ComboBox();
            this.dtpRequredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipRagion = new System.Windows.Forms.TextBox();
            this.nFeight = new System.Windows.Forms.NumericUpDown();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(12, 55);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(158, 274);
            this.lstProducts.TabIndex = 0;
            // 
            // lstCart
            // 
            this.lstCart.Location = new System.Drawing.Point(190, 51);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(158, 278);
            this.lstCart.TabIndex = 1;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 16);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(158, 23);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(190, 16);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(111, 19);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam : 0.00 ₺";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 335);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(190, 335);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(73, 23);
            this.btnAzalt.TabIndex = 5;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArtir
            // 
            this.btnArtir.Location = new System.Drawing.Point(275, 335);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(73, 23);
            this.btnArtir.TabIndex = 6;
            this.btnArtir.Text = "Artır";
            this.btnArtir.UseVisualStyleBackColor = true;
            this.btnArtir.Click += new System.EventHandler(this.btnArtir_Click);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(354, 51);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(206, 23);
            this.cmbEmployee.TabIndex = 7;
            // 
            // cbmShippers
            // 
            this.cbmShippers.FormattingEnabled = true;
            this.cbmShippers.Location = new System.Drawing.Point(354, 80);
            this.cbmShippers.Name = "cbmShippers";
            this.cbmShippers.Size = new System.Drawing.Size(206, 23);
            this.cbmShippers.TabIndex = 8;
            // 
            // dtpRequredDate
            // 
            this.dtpRequredDate.Location = new System.Drawing.Point(354, 109);
            this.dtpRequredDate.Name = "dtpRequredDate";
            this.dtpRequredDate.Size = new System.Drawing.Size(206, 23);
            this.dtpRequredDate.TabIndex = 9;
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(354, 138);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(100, 23);
            this.txtShipAdress.TabIndex = 11;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(354, 167);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(100, 23);
            this.txtShipCountry.TabIndex = 12;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(354, 196);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(100, 23);
            this.txtShipPostalCode.TabIndex = 13;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(460, 138);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(100, 23);
            this.txtShipCity.TabIndex = 14;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(460, 167);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(100, 23);
            this.txtShipName.TabIndex = 15;
            // 
            // txtShipRagion
            // 
            this.txtShipRagion.Location = new System.Drawing.Point(460, 196);
            this.txtShipRagion.Name = "txtShipRagion";
            this.txtShipRagion.Size = new System.Drawing.Size(100, 23);
            this.txtShipRagion.TabIndex = 16;
            // 
            // nFeight
            // 
            this.nFeight.DecimalPlaces = 2;
            this.nFeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nFeight.Location = new System.Drawing.Point(354, 303);
            this.nFeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nFeight.Name = "nFeight";
            this.nFeight.Size = new System.Drawing.Size(100, 26);
            this.nFeight.TabIndex = 17;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(354, 335);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(206, 23);
            this.btnOnayla.TabIndex = 18;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(547, 269);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 23);
            this.cmbCustomer.TabIndex = 19;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbmCustomer_SelectedIndexChanged);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 452);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.nFeight);
            this.Controls.Add(this.txtShipRagion);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.txtShipPostalCode);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.txtShipAdress);
            this.Controls.Add(this.dtpRequredDate);
            this.Controls.Add(this.cbmShippers);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnArtir);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lstProducts);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstProducts;
        private ListView lstCart;
        private TextBox txtAra;
        private Label lblToplam;
        private Button btnEkle;
        private Button btnAzalt;
        private Button btnArtir;
        private ComboBox cmbEmployee;
        private ComboBox cbmShippers;
        private DateTimePicker dtpRequredDate;
        private TextBox txtShipAdress;
        private TextBox txtShipCountry;
        private TextBox txtShipPostalCode;
        private TextBox txtShipCity;
        private TextBox txtShipName;
        private TextBox txtShipRagion;
        private NumericUpDown nFeight;
        private Button btnOnayla;
        private ComboBox cmbCustomer;
    }
}