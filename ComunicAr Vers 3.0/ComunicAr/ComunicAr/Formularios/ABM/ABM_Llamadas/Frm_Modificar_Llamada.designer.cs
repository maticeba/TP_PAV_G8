
namespace ComunicAr.Formularios.ABM_Llamadas
{
    partial class Frm_Modificar_Llamadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_llamada_mod_aceptar = new System.Windows.Forms.Button();
            this.btn_llamada_mod_cancelar = new System.Windows.Forms.Button();
            this.btn_llamada_mod_buscar_receptor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_llamada_mod_buscar_emisor = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cmb_llamada_mod_fin_hs = new ComunicAr.Clases.ComboBox02();
            this.cmb_llamada_mod_fin_segs = new ComunicAr.Clases.ComboBox02();
            this.cmb_llamada_mod_fin_mins = new ComunicAr.Clases.ComboBox02();
            this.cmb_llamada_mod_inicio_seg = new ComunicAr.Clases.ComboBox02();
            this.cmb_llamada_mod_inicio_mins = new ComunicAr.Clases.ComboBox02();
            this.cmb_llamada_mod_inicio_hs = new ComunicAr.Clases.ComboBox02();
            this.txt_llamada_mod_fecha_fin = new ComunicAr.Clases.TextBox01();
            this.txtBox_llamadas_mod_idReceptor = new ComunicAr.Clases.TextBox01();
            this.cmb_llamada_mod_tel_receptor = new ComunicAr.Clases.ComboBox02();
            this.txtbox_llamada_mod_fecha_inicio = new ComunicAr.Clases.TextBox01();
            this.txtBox_llamadas_mod_idEmisor = new ComunicAr.Clases.TextBox01();
            this.cmb_llamada_mod_tel_emisor = new ComunicAr.Clases.ComboBox02();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Llamadas";
            // 
            // btn_llamada_mod_aceptar
            // 
            this.btn_llamada_mod_aceptar.Location = new System.Drawing.Point(250, 390);
            this.btn_llamada_mod_aceptar.Name = "btn_llamada_mod_aceptar";
            this.btn_llamada_mod_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_llamada_mod_aceptar.TabIndex = 16;
            this.btn_llamada_mod_aceptar.Text = "Aceptar";
            this.btn_llamada_mod_aceptar.UseVisualStyleBackColor = true;
            this.btn_llamada_mod_aceptar.Click += new System.EventHandler(this.btn_cliente_mod_aceptar_Click);
            // 
            // btn_llamada_mod_cancelar
            // 
            this.btn_llamada_mod_cancelar.Location = new System.Drawing.Point(331, 390);
            this.btn_llamada_mod_cancelar.Name = "btn_llamada_mod_cancelar";
            this.btn_llamada_mod_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_llamada_mod_cancelar.TabIndex = 17;
            this.btn_llamada_mod_cancelar.Text = "Cancelar";
            this.btn_llamada_mod_cancelar.UseVisualStyleBackColor = true;
            this.btn_llamada_mod_cancelar.Click += new System.EventHandler(this.btn_cliente_mod_cancelar_Click);
            // 
            // btn_llamada_mod_buscar_receptor
            // 
            this.btn_llamada_mod_buscar_receptor.Location = new System.Drawing.Point(294, 164);
            this.btn_llamada_mod_buscar_receptor.Name = "btn_llamada_mod_buscar_receptor";
            this.btn_llamada_mod_buscar_receptor.Size = new System.Drawing.Size(58, 23);
            this.btn_llamada_mod_buscar_receptor.TabIndex = 5;
            this.btn_llamada_mod_buscar_receptor.Text = "Buscar";
            this.btn_llamada_mod_buscar_receptor.UseVisualStyleBackColor = true;
            this.btn_llamada_mod_buscar_receptor.Click += new System.EventHandler(this.btn_llamada_mod_buscar_receptor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Id Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro. de Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "seg.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "min.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "hs.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Horario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(80, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nro. de Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Cliente";
            // 
            // btn_llamada_mod_buscar_emisor
            // 
            this.btn_llamada_mod_buscar_emisor.Location = new System.Drawing.Point(294, 67);
            this.btn_llamada_mod_buscar_emisor.Name = "btn_llamada_mod_buscar_emisor";
            this.btn_llamada_mod_buscar_emisor.Size = new System.Drawing.Size(58, 23);
            this.btn_llamada_mod_buscar_emisor.TabIndex = 2;
            this.btn_llamada_mod_buscar_emisor.Text = "Buscar";
            this.btn_llamada_mod_buscar_emisor.UseVisualStyleBackColor = true;
            this.btn_llamada_mod_buscar_emisor.Click += new System.EventHandler(this.btn_llamada_mod_buscar_emisor_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Emisor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "seg.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Horario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "hs.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "min.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(392, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "_____________________________________________________________________________\r\n";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 24;
            this.label20.Text = "Receptor";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(392, 15);
            this.label21.TabIndex = 29;
            this.label21.Text = "_____________________________________________________________________________\r\n";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 15);
            this.label22.TabIndex = 24;
            this.label22.Text = "Inicio Llamada";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 295);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(392, 15);
            this.label24.TabIndex = 29;
            this.label24.Text = "_____________________________________________________________________________\r\n";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 320);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 15);
            this.label25.TabIndex = 24;
            this.label25.Text = "Fin Llamada";
            // 
            // cmb_llamada_mod_fin_hs
            // 
            this.cmb_llamada_mod_fin_hs.Enable = false;
            this.cmb_llamada_mod_fin_hs.FormattingEnabled = true;
            this.cmb_llamada_mod_fin_hs.Location = new System.Drawing.Point(124, 358);
            this.cmb_llamada_mod_fin_hs.Name = "cmb_llamada_mod_fin_hs";
            this.cmb_llamada_mod_fin_hs.Pp_Conseleccion = false;
            this.cmb_llamada_mod_fin_hs.Pp_Descripcion1 = null;
            this.cmb_llamada_mod_fin_hs.Pp_Descripcion2 = null;
            this.cmb_llamada_mod_fin_hs.Pp_Descripcion3 = null;
            this.cmb_llamada_mod_fin_hs.Pp_MensajeError = "No ha insertado bien el horario de fin [hs]";
            this.cmb_llamada_mod_fin_hs.Pp_NombreCampo = null;
            this.cmb_llamada_mod_fin_hs.Pp_NombreTabla = null;
            this.cmb_llamada_mod_fin_hs.Pp_PK1 = null;
            this.cmb_llamada_mod_fin_hs.Pp_Tabla = null;
            this.cmb_llamada_mod_fin_hs.Pp_Validable = false;
            this.cmb_llamada_mod_fin_hs.Size = new System.Drawing.Size(40, 23);
            this.cmb_llamada_mod_fin_hs.TabIndex = 32;
            // 
            // cmb_llamada_mod_fin_segs
            // 
            this.cmb_llamada_mod_fin_segs.Enable = false;
            this.cmb_llamada_mod_fin_segs.FormattingEnabled = true;
            this.cmb_llamada_mod_fin_segs.Location = new System.Drawing.Point(285, 358);
            this.cmb_llamada_mod_fin_segs.Name = "cmb_llamada_mod_fin_segs";
            this.cmb_llamada_mod_fin_segs.Pp_Conseleccion = false;
            this.cmb_llamada_mod_fin_segs.Pp_Descripcion1 = null;
            this.cmb_llamada_mod_fin_segs.Pp_Descripcion2 = null;
            this.cmb_llamada_mod_fin_segs.Pp_Descripcion3 = null;
            this.cmb_llamada_mod_fin_segs.Pp_MensajeError = "No ha insertado bien el horario de fin [seg]";
            this.cmb_llamada_mod_fin_segs.Pp_NombreCampo = null;
            this.cmb_llamada_mod_fin_segs.Pp_NombreTabla = null;
            this.cmb_llamada_mod_fin_segs.Pp_PK1 = null;
            this.cmb_llamada_mod_fin_segs.Pp_Tabla = null;
            this.cmb_llamada_mod_fin_segs.Pp_Validable = false;
            this.cmb_llamada_mod_fin_segs.Size = new System.Drawing.Size(42, 23);
            this.cmb_llamada_mod_fin_segs.TabIndex = 31;
            // 
            // cmb_llamada_mod_fin_mins
            // 
            this.cmb_llamada_mod_fin_mins.Enable = false;
            this.cmb_llamada_mod_fin_mins.FormattingEnabled = true;
            this.cmb_llamada_mod_fin_mins.Location = new System.Drawing.Point(200, 358);
            this.cmb_llamada_mod_fin_mins.Name = "cmb_llamada_mod_fin_mins";
            this.cmb_llamada_mod_fin_mins.Pp_Conseleccion = false;
            this.cmb_llamada_mod_fin_mins.Pp_Descripcion1 = null;
            this.cmb_llamada_mod_fin_mins.Pp_Descripcion2 = null;
            this.cmb_llamada_mod_fin_mins.Pp_Descripcion3 = null;
            this.cmb_llamada_mod_fin_mins.Pp_MensajeError = "No ha insertado bien el horario de fin [min]";
            this.cmb_llamada_mod_fin_mins.Pp_NombreCampo = null;
            this.cmb_llamada_mod_fin_mins.Pp_NombreTabla = null;
            this.cmb_llamada_mod_fin_mins.Pp_PK1 = null;
            this.cmb_llamada_mod_fin_mins.Pp_Tabla = null;
            this.cmb_llamada_mod_fin_mins.Pp_Validable = false;
            this.cmb_llamada_mod_fin_mins.Size = new System.Drawing.Size(42, 23);
            this.cmb_llamada_mod_fin_mins.TabIndex = 30;
            // 
            // cmb_llamada_mod_inicio_seg
            // 
            this.cmb_llamada_mod_inicio_seg.Enable = false;
            this.cmb_llamada_mod_inicio_seg.FormattingEnabled = true;
            this.cmb_llamada_mod_inicio_seg.Location = new System.Drawing.Point(285, 277);
            this.cmb_llamada_mod_inicio_seg.Name = "cmb_llamada_mod_inicio_seg";
            this.cmb_llamada_mod_inicio_seg.Pp_Conseleccion = false;
            this.cmb_llamada_mod_inicio_seg.Pp_Descripcion1 = null;
            this.cmb_llamada_mod_inicio_seg.Pp_Descripcion2 = null;
            this.cmb_llamada_mod_inicio_seg.Pp_Descripcion3 = null;
            this.cmb_llamada_mod_inicio_seg.Pp_MensajeError = "No ha insertado bien el horario de inicio[seg]";
            this.cmb_llamada_mod_inicio_seg.Pp_NombreCampo = null;
            this.cmb_llamada_mod_inicio_seg.Pp_NombreTabla = null;
            this.cmb_llamada_mod_inicio_seg.Pp_PK1 = null;
            this.cmb_llamada_mod_inicio_seg.Pp_Tabla = null;
            this.cmb_llamada_mod_inicio_seg.Pp_Validable = false;
            this.cmb_llamada_mod_inicio_seg.Size = new System.Drawing.Size(42, 23);
            this.cmb_llamada_mod_inicio_seg.TabIndex = 31;
            // 
            // cmb_llamada_mod_inicio_mins
            // 
            this.cmb_llamada_mod_inicio_mins.Enable = false;
            this.cmb_llamada_mod_inicio_mins.FormattingEnabled = true;
            this.cmb_llamada_mod_inicio_mins.Location = new System.Drawing.Point(200, 277);
            this.cmb_llamada_mod_inicio_mins.Name = "cmb_llamada_mod_inicio_mins";
            this.cmb_llamada_mod_inicio_mins.Pp_Conseleccion = false;
            this.cmb_llamada_mod_inicio_mins.Pp_Descripcion1 = null;
            this.cmb_llamada_mod_inicio_mins.Pp_Descripcion2 = null;
            this.cmb_llamada_mod_inicio_mins.Pp_Descripcion3 = null;
            this.cmb_llamada_mod_inicio_mins.Pp_MensajeError = "No ha insertado bien el horario de inicio [min]";
            this.cmb_llamada_mod_inicio_mins.Pp_NombreCampo = null;
            this.cmb_llamada_mod_inicio_mins.Pp_NombreTabla = null;
            this.cmb_llamada_mod_inicio_mins.Pp_PK1 = null;
            this.cmb_llamada_mod_inicio_mins.Pp_Tabla = null;
            this.cmb_llamada_mod_inicio_mins.Pp_Validable = false;
            this.cmb_llamada_mod_inicio_mins.Size = new System.Drawing.Size(42, 23);
            this.cmb_llamada_mod_inicio_mins.TabIndex = 30;
            // 
            // cmb_llamada_mod_inicio_hs
            // 
            this.cmb_llamada_mod_inicio_hs.Enable = false;
            this.cmb_llamada_mod_inicio_hs.FormattingEnabled = true;
            this.cmb_llamada_mod_inicio_hs.Location = new System.Drawing.Point(124, 277);
            this.cmb_llamada_mod_inicio_hs.Name = "cmb_llamada_mod_inicio_hs";
            this.cmb_llamada_mod_inicio_hs.Pp_Conseleccion = false;
            this.cmb_llamada_mod_inicio_hs.Pp_Descripcion1 = null;
            this.cmb_llamada_mod_inicio_hs.Pp_Descripcion2 = null;
            this.cmb_llamada_mod_inicio_hs.Pp_Descripcion3 = null;
            this.cmb_llamada_mod_inicio_hs.Pp_MensajeError = "No ha insertado bien el horario de inicio[hs]";
            this.cmb_llamada_mod_inicio_hs.Pp_NombreCampo = null;
            this.cmb_llamada_mod_inicio_hs.Pp_NombreTabla = null;
            this.cmb_llamada_mod_inicio_hs.Pp_PK1 = null;
            this.cmb_llamada_mod_inicio_hs.Pp_Tabla = null;
            this.cmb_llamada_mod_inicio_hs.Pp_Validable = false;
            this.cmb_llamada_mod_inicio_hs.Size = new System.Drawing.Size(42, 23);
            this.cmb_llamada_mod_inicio_hs.TabIndex = 30;
            // 
            // txt_llamada_mod_fecha_fin
            // 
            this.txt_llamada_mod_fecha_fin.Location = new System.Drawing.Point(124, 332);
            this.txt_llamada_mod_fecha_fin.Name = "txt_llamada_mod_fecha_fin";
            this.txt_llamada_mod_fecha_fin.Pp_Campo = null;
            this.txt_llamada_mod_fecha_fin.Pp_MensajeError = "No se ha insertado ninguna fecha de fin";
            this.txt_llamada_mod_fecha_fin.Pp_Tabla = null;
            this.txt_llamada_mod_fecha_fin.Pp_Validable = false;
            this.txt_llamada_mod_fecha_fin.Size = new System.Drawing.Size(93, 23);
            this.txt_llamada_mod_fecha_fin.TabIndex = 10;
            this.txt_llamada_mod_fecha_fin.Text = "DD/MM/YYYY";
            // 
            // txtBox_llamadas_mod_idReceptor
            // 
            this.txtBox_llamadas_mod_idReceptor.Location = new System.Drawing.Point(124, 164);
            this.txtBox_llamadas_mod_idReceptor.Name = "txtBox_llamadas_mod_idReceptor";
            this.txtBox_llamadas_mod_idReceptor.Pp_Campo = null;
            this.txtBox_llamadas_mod_idReceptor.Pp_MensajeError = "No se ha insertado ningun id de cliente receptor";
            this.txtBox_llamadas_mod_idReceptor.Pp_Tabla = null;
            this.txtBox_llamadas_mod_idReceptor.Pp_Validable = false;
            this.txtBox_llamadas_mod_idReceptor.Size = new System.Drawing.Size(164, 23);
            this.txtBox_llamadas_mod_idReceptor.TabIndex = 3;
            // 
            // cmb_llamada_mod_tel_receptor
            // 
            this.cmb_llamada_mod_tel_receptor.Enable = false;
            this.cmb_llamada_mod_tel_receptor.FormattingEnabled = true;
            this.cmb_llamada_mod_tel_receptor.Location = new System.Drawing.Point(124, 193);
            this.cmb_llamada_mod_tel_receptor.Name = "cmb_llamada_mod_tel_receptor";
            this.cmb_llamada_mod_tel_receptor.Pp_Conseleccion = true;
            this.cmb_llamada_mod_tel_receptor.Pp_Descripcion1 = "cod_nacional";
            this.cmb_llamada_mod_tel_receptor.Pp_Descripcion2 = "cod_area";
            this.cmb_llamada_mod_tel_receptor.Pp_Descripcion3 = "nro_telefono";
            this.cmb_llamada_mod_tel_receptor.Pp_MensajeError = "No has seleccionado ningún teléfono receptor";
            this.cmb_llamada_mod_tel_receptor.Pp_NombreCampo = null;
            this.cmb_llamada_mod_tel_receptor.Pp_NombreTabla = null;
            this.cmb_llamada_mod_tel_receptor.Pp_PK1 = "id_numero";
            this.cmb_llamada_mod_tel_receptor.Pp_Tabla = "Numero";
            this.cmb_llamada_mod_tel_receptor.Pp_Validable = false;
            this.cmb_llamada_mod_tel_receptor.Size = new System.Drawing.Size(164, 23);
            this.cmb_llamada_mod_tel_receptor.TabIndex = 4;
            // 
            // txtbox_llamada_mod_fecha_inicio
            // 
            this.txtbox_llamada_mod_fecha_inicio.Location = new System.Drawing.Point(124, 251);
            this.txtbox_llamada_mod_fecha_inicio.Name = "txtbox_llamada_mod_fecha_inicio";
            this.txtbox_llamada_mod_fecha_inicio.Pp_Campo = null;
            this.txtbox_llamada_mod_fecha_inicio.Pp_MensajeError = "No se ha insertado ninguna fecha de inicio";
            this.txtbox_llamada_mod_fecha_inicio.Pp_Tabla = null;
            this.txtbox_llamada_mod_fecha_inicio.Pp_Validable = false;
            this.txtbox_llamada_mod_fecha_inicio.Size = new System.Drawing.Size(93, 23);
            this.txtbox_llamada_mod_fecha_inicio.TabIndex = 6;
            this.txtbox_llamada_mod_fecha_inicio.Text = "DD/MM/YYYY";
            // 
            // txtBox_llamadas_mod_idEmisor
            // 
            this.txtBox_llamadas_mod_idEmisor.Location = new System.Drawing.Point(124, 67);
            this.txtBox_llamadas_mod_idEmisor.Name = "txtBox_llamadas_mod_idEmisor";
            this.txtBox_llamadas_mod_idEmisor.Pp_Campo = null;
            this.txtBox_llamadas_mod_idEmisor.Pp_MensajeError = "No se ha ingresado el id del cliente emisor";
            this.txtBox_llamadas_mod_idEmisor.Pp_Tabla = null;
            this.txtBox_llamadas_mod_idEmisor.Pp_Validable = false;
            this.txtBox_llamadas_mod_idEmisor.Size = new System.Drawing.Size(164, 23);
            this.txtBox_llamadas_mod_idEmisor.TabIndex = 0;
            // 
            // cmb_llamada_mod_tel_emisor
            // 
            this.cmb_llamada_mod_tel_emisor.Enable = false;
            this.cmb_llamada_mod_tel_emisor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_llamada_mod_tel_emisor.FormattingEnabled = true;
            this.cmb_llamada_mod_tel_emisor.Location = new System.Drawing.Point(124, 96);
            this.cmb_llamada_mod_tel_emisor.Name = "cmb_llamada_mod_tel_emisor";
            this.cmb_llamada_mod_tel_emisor.Pp_Conseleccion = true;
            this.cmb_llamada_mod_tel_emisor.Pp_Descripcion1 = "cod_nacional";
            this.cmb_llamada_mod_tel_emisor.Pp_Descripcion2 = "cod_area";
            this.cmb_llamada_mod_tel_emisor.Pp_Descripcion3 = "nro_telefono";
            this.cmb_llamada_mod_tel_emisor.Pp_MensajeError = "No has seleccionado ningún teléfono emisor";
            this.cmb_llamada_mod_tel_emisor.Pp_NombreCampo = null;
            this.cmb_llamada_mod_tel_emisor.Pp_NombreTabla = null;
            this.cmb_llamada_mod_tel_emisor.Pp_PK1 = "id_numero";
            this.cmb_llamada_mod_tel_emisor.Pp_Tabla = "Numero";
            this.cmb_llamada_mod_tel_emisor.Pp_Validable = false;
            this.cmb_llamada_mod_tel_emisor.Size = new System.Drawing.Size(164, 23);
            this.cmb_llamada_mod_tel_emisor.TabIndex = 1;
            this.cmb_llamada_mod_tel_emisor.SelectedIndexChanged += new System.EventHandler(this.cmb_llamada_mod_tel_emisor_SelectedIndexChanged);
            // 
            // Frm_Modificar_Llamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 417);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_llamada_mod_fin_hs);
            this.Controls.Add(this.cmb_llamada_mod_fin_segs);
            this.Controls.Add(this.cmb_llamada_mod_fin_mins);
            this.Controls.Add(this.cmb_llamada_mod_inicio_seg);
            this.Controls.Add(this.cmb_llamada_mod_inicio_mins);
            this.Controls.Add(this.cmb_llamada_mod_inicio_hs);
            this.Controls.Add(this.txt_llamada_mod_fecha_fin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_llamadas_mod_idReceptor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_llamada_mod_buscar_receptor);
            this.Controls.Add(this.cmb_llamada_mod_tel_receptor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_llamada_mod_fecha_inicio);
            this.Controls.Add(this.btn_llamada_mod_buscar_emisor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBox_llamadas_mod_idEmisor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_llamada_mod_tel_emisor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_llamada_mod_cancelar);
            this.Controls.Add(this.btn_llamada_mod_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Llamadas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Modificar_Llamadas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_llamada_mod_aceptar;
        private System.Windows.Forms.Button btn_llamada_mod_cancelar;
        private Clases.TextBox01 txtBox_llamadas_mod_idReceptor;
        private System.Windows.Forms.Button btn_llamada_mod_buscar_receptor;
        private Clases.ComboBox02 cmb_llamada_mod_tel_receptor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private Clases.TextBox01 txt_llamada_mod_fecha_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox02 cmb_llamada_mod_tel_emisor;
        private System.Windows.Forms.Button btn_llamada_mod_buscar_emisor;
        private Clases.TextBox01 txtBox_llamadas_mod_idEmisor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Clases.TextBox01 txtbox_llamada_mod_fecha_inicio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private Clases.ComboBox02 cmb_llamada_mod_inicio_hs;
        private Clases.ComboBox02 cmb_llamada_mod_inicio_mins;
        private Clases.ComboBox02 cmb_llamada_mod_inicio_seg;
        private Clases.ComboBox02 cmb_llamada_mod_fin_hs;
        private Clases.ComboBox02 cmb_llamada_mod_fin_mins;
        private Clases.ComboBox02 cmb_llamada_mod_fin_segs;
    }
}