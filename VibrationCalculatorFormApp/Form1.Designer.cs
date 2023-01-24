
namespace VibrationCalculatorFormApp {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TSensitivity = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.radSensitivityM = new System.Windows.Forms.RadioButton();
            this.radSensitivityG = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radFrequencyRPM = new System.Windows.Forms.RadioButton();
            this.radFrequencyHw = new System.Windows.Forms.RadioButton();
            this.TFrequency = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radVoltagePikPik = new System.Windows.Forms.RadioButton();
            this.radVoltagePik = new System.Windows.Forms.RadioButton();
            this.radVoltageRMS = new System.Windows.Forms.RadioButton();
            this.TVoltage_dB = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.TVoltage = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVoltSensFreq = new System.Windows.Forms.RadioButton();
            this.radDispSensFreq = new System.Windows.Forms.RadioButton();
            this.radVelSensFreq = new System.Windows.Forms.RadioButton();
            this.radAccSensFreq = new System.Windows.Forms.RadioButton();
            this.GBDisplacement = new System.Windows.Forms.GroupBox();
            this.radiDisplacementPikPik = new System.Windows.Forms.RadioButton();
            this.radDisplacementPik = new System.Windows.Forms.RadioButton();
            this.radDisplacementRMS = new System.Windows.Forms.RadioButton();
            this.TDisplacement = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.TDisplacement_dB = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gBVelocity = new System.Windows.Forms.GroupBox();
            this.radVelocityPikPik = new System.Windows.Forms.RadioButton();
            this.radVelocityPik = new System.Windows.Forms.RadioButton();
            this.radVelocityRMS = new System.Windows.Forms.RadioButton();
            this.TVelocity = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.TVelocity_dB = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gBAcceleration = new System.Windows.Forms.GroupBox();
            this.radAccelerationPikPik = new System.Windows.Forms.RadioButton();
            this.radAccelerationPik = new System.Windows.Forms.RadioButton();
            this.radAccelerationRMS = new System.Windows.Forms.RadioButton();
            this.TAcceleration = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.TAcceleration_dB = new VibrationCalculatorFormApp.ModifiedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBDisplacement.SuspendLayout();
            this.gBVelocity.SuspendLayout();
            this.gBAcceleration.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TSensitivity);
            this.groupBox2.Controls.Add(this.radSensitivityM);
            this.groupBox2.Controls.Add(this.radSensitivityG);
            this.groupBox2.Location = new System.Drawing.Point(75, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 95);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "КП датчика";
            // 
            // TSensitivity
            // 
            this.TSensitivity.Location = new System.Drawing.Point(31, 19);
            this.TSensitivity.Name = "TSensitivity";
            this.TSensitivity.Size = new System.Drawing.Size(86, 20);
            this.TSensitivity.TabIndex = 12;
            this.TSensitivity.Text = "100";
            this.TSensitivity.TextChanged += new System.EventHandler(this.TSensitivity_TextChanged);
            this.TSensitivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSensitivity_KeyPress);
            // 
            // radSensitivityM
            // 
            this.radSensitivityM.AutoSize = true;
            this.radSensitivityM.Location = new System.Drawing.Point(106, 46);
            this.radSensitivityM.Name = "radSensitivityM";
            this.radSensitivityM.Size = new System.Drawing.Size(74, 17);
            this.radSensitivityM.TabIndex = 11;
            this.radSensitivityM.Text = "мВ/м•с ̄ ²";
            this.radSensitivityM.UseVisualStyleBackColor = true;
            this.radSensitivityM.CheckedChanged += new System.EventHandler(this.radSensitivityM_CheckedChanged);
            // 
            // radSensitivityG
            // 
            this.radSensitivityG.AutoSize = true;
            this.radSensitivityG.Checked = true;
            this.radSensitivityG.Location = new System.Drawing.Point(31, 46);
            this.radSensitivityG.Name = "radSensitivityG";
            this.radSensitivityG.Size = new System.Drawing.Size(51, 17);
            this.radSensitivityG.TabIndex = 10;
            this.radSensitivityG.TabStop = true;
            this.radSensitivityG.Text = "мВ/g";
            this.radSensitivityG.UseVisualStyleBackColor = true;
            this.radSensitivityG.CheckedChanged += new System.EventHandler(this.radSensitivityG_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radFrequencyRPM);
            this.groupBox3.Controls.Add(this.radFrequencyHw);
            this.groupBox3.Controls.Add(this.TFrequency);
            this.groupBox3.Location = new System.Drawing.Point(310, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 95);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Частота, Гц";
            // 
            // radFrequencyRPM
            // 
            this.radFrequencyRPM.AutoSize = true;
            this.radFrequencyRPM.Location = new System.Drawing.Point(50, 46);
            this.radFrequencyRPM.Name = "radFrequencyRPM";
            this.radFrequencyRPM.Size = new System.Drawing.Size(70, 17);
            this.radFrequencyRPM.TabIndex = 10;
            this.radFrequencyRPM.Text = "Об./мин.";
            this.radFrequencyRPM.UseVisualStyleBackColor = true;
            this.radFrequencyRPM.CheckedChanged += new System.EventHandler(this.radFrequencyRPM_CheckedChanged);
            // 
            // radFrequencyHw
            // 
            this.radFrequencyHw.AutoSize = true;
            this.radFrequencyHw.Checked = true;
            this.radFrequencyHw.Location = new System.Drawing.Point(6, 45);
            this.radFrequencyHw.Name = "radFrequencyHw";
            this.radFrequencyHw.Size = new System.Drawing.Size(37, 17);
            this.radFrequencyHw.TabIndex = 9;
            this.radFrequencyHw.TabStop = true;
            this.radFrequencyHw.Text = "Гц";
            this.radFrequencyHw.UseVisualStyleBackColor = true;
            this.radFrequencyHw.CheckedChanged += new System.EventHandler(this.radFrequencyHw_CheckedChanged);
            // 
            // TFrequency
            // 
            this.TFrequency.Location = new System.Drawing.Point(6, 19);
            this.TFrequency.Name = "TFrequency";
            this.TFrequency.Size = new System.Drawing.Size(89, 20);
            this.TFrequency.TabIndex = 7;
            this.TFrequency.Text = "159,2";
            this.TFrequency.TextChanged += new System.EventHandler(this.TFrequency_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radVoltagePikPik);
            this.groupBox4.Controls.Add(this.radVoltagePik);
            this.groupBox4.Controls.Add(this.radVoltageRMS);
            this.groupBox4.Controls.Add(this.TVoltage_dB);
            this.groupBox4.Controls.Add(this.TVoltage);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(31, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 72);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Напряжение, мВ";
            // 
            // radVoltagePikPik
            // 
            this.radVoltagePikPik.AutoSize = true;
            this.radVoltagePikPik.Location = new System.Drawing.Point(92, 45);
            this.radVoltagePikPik.Name = "radVoltagePikPik";
            this.radVoltagePikPik.Size = new System.Drawing.Size(63, 17);
            this.radVoltagePikPik.TabIndex = 10;
            this.radVoltagePikPik.Text = "Размах";
            this.radVoltagePikPik.UseVisualStyleBackColor = true;
            this.radVoltagePikPik.CheckedChanged += new System.EventHandler(this.radVoltagePikPik_CheckedChanged);
            // 
            // radVoltagePik
            // 
            this.radVoltagePik.AutoSize = true;
            this.radVoltagePik.Location = new System.Drawing.Point(49, 45);
            this.radVoltagePik.Name = "radVoltagePik";
            this.radVoltagePik.Size = new System.Drawing.Size(45, 17);
            this.radVoltagePik.TabIndex = 10;
            this.radVoltagePik.Text = "Пик";
            this.radVoltagePik.UseVisualStyleBackColor = true;
            this.radVoltagePik.CheckedChanged += new System.EventHandler(this.radVoltagePik_CheckedChanged);
            // 
            // radVoltageRMS
            // 
            this.radVoltageRMS.AutoSize = true;
            this.radVoltageRMS.Checked = true;
            this.radVoltageRMS.Location = new System.Drawing.Point(6, 45);
            this.radVoltageRMS.Name = "radVoltageRMS";
            this.radVoltageRMS.Size = new System.Drawing.Size(46, 17);
            this.radVoltageRMS.TabIndex = 9;
            this.radVoltageRMS.TabStop = true;
            this.radVoltageRMS.Text = "СКЗ";
            this.radVoltageRMS.UseVisualStyleBackColor = true;
            this.radVoltageRMS.CheckedChanged += new System.EventHandler(this.radVoltageRMS_CheckedChanged);
            // 
            // TVoltage_dB
            // 
            this.TVoltage_dB.Location = new System.Drawing.Point(212, 16);
            this.TVoltage_dB.Name = "TVoltage_dB";
            this.TVoltage_dB.Size = new System.Drawing.Size(90, 20);
            this.TVoltage_dB.TabIndex = 15;
            this.TVoltage_dB.TextChanged += new System.EventHandler(this.TVoltage_dB_TextChanged);
            // 
            // TVoltage
            // 
            this.TVoltage.Location = new System.Drawing.Point(6, 19);
            this.TVoltage.Name = "TVoltage";
            this.TVoltage.Size = new System.Drawing.Size(90, 20);
            this.TVoltage.TabIndex = 7;
            this.TVoltage.Text = "100";
            this.TVoltage.TextChanged += new System.EventHandler(this.TVoltage_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Напряжение, дБ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVoltSensFreq);
            this.groupBox1.Controls.Add(this.radDispSensFreq);
            this.groupBox1.Controls.Add(this.radVelSensFreq);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.radAccSensFreq);
            this.groupBox1.Controls.Add(this.GBDisplacement);
            this.groupBox1.Controls.Add(this.gBVelocity);
            this.groupBox1.Controls.Add(this.gBAcceleration);
            this.groupBox1.Location = new System.Drawing.Point(75, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 364);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры ";
            // 
            // radVoltSensFreq
            // 
            this.radVoltSensFreq.AutoSize = true;
            this.radVoltSensFreq.Location = new System.Drawing.Point(13, 60);
            this.radVoltSensFreq.Name = "radVoltSensFreq";
            this.radVoltSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radVoltSensFreq.TabIndex = 20;
            this.radVoltSensFreq.UseVisualStyleBackColor = true;
            this.radVoltSensFreq.CheckedChanged += new System.EventHandler(this.radVoltSensFreq_CheckedChanged);
            // 
            // radDispSensFreq
            // 
            this.radDispSensFreq.AutoSize = true;
            this.radDispSensFreq.Location = new System.Drawing.Point(13, 290);
            this.radDispSensFreq.Name = "radDispSensFreq";
            this.radDispSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radDispSensFreq.TabIndex = 15;
            this.radDispSensFreq.UseVisualStyleBackColor = true;
            this.radDispSensFreq.CheckedChanged += new System.EventHandler(this.radDispSensFreq_CheckedChanged);
            // 
            // radVelSensFreq
            // 
            this.radVelSensFreq.AutoSize = true;
            this.radVelSensFreq.Location = new System.Drawing.Point(13, 212);
            this.radVelSensFreq.Name = "radVelSensFreq";
            this.radVelSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radVelSensFreq.TabIndex = 14;
            this.radVelSensFreq.UseVisualStyleBackColor = true;
            this.radVelSensFreq.CheckedChanged += new System.EventHandler(this.radVelSensFreq_CheckedChanged);
            // 
            // radAccSensFreq
            // 
            this.radAccSensFreq.AutoSize = true;
            this.radAccSensFreq.Checked = true;
            this.radAccSensFreq.Location = new System.Drawing.Point(13, 134);
            this.radAccSensFreq.Name = "radAccSensFreq";
            this.radAccSensFreq.Size = new System.Drawing.Size(14, 13);
            this.radAccSensFreq.TabIndex = 13;
            this.radAccSensFreq.TabStop = true;
            this.radAccSensFreq.UseVisualStyleBackColor = true;
            this.radAccSensFreq.CheckedChanged += new System.EventHandler(this.radAccSensFreq_CheckedChanged);
            // 
            // GBDisplacement
            // 
            this.GBDisplacement.Controls.Add(this.radiDisplacementPikPik);
            this.GBDisplacement.Controls.Add(this.radDisplacementPik);
            this.GBDisplacement.Controls.Add(this.radDisplacementRMS);
            this.GBDisplacement.Controls.Add(this.TDisplacement);
            this.GBDisplacement.Controls.Add(this.TDisplacement_dB);
            this.GBDisplacement.Controls.Add(this.label10);
            this.GBDisplacement.Location = new System.Drawing.Point(31, 268);
            this.GBDisplacement.Name = "GBDisplacement";
            this.GBDisplacement.Size = new System.Drawing.Size(353, 72);
            this.GBDisplacement.TabIndex = 12;
            this.GBDisplacement.TabStop = false;
            this.GBDisplacement.Text = "Перемещение, мкм";
            // 
            // radiDisplacementPikPik
            // 
            this.radiDisplacementPikPik.AutoSize = true;
            this.radiDisplacementPikPik.Location = new System.Drawing.Point(92, 45);
            this.radiDisplacementPikPik.Name = "radiDisplacementPikPik";
            this.radiDisplacementPikPik.Size = new System.Drawing.Size(63, 17);
            this.radiDisplacementPikPik.TabIndex = 10;
            this.radiDisplacementPikPik.Text = "Размах";
            this.radiDisplacementPikPik.UseVisualStyleBackColor = true;
            this.radiDisplacementPikPik.CheckedChanged += new System.EventHandler(this.radiDisplacementPikPik_CheckedChanged);
            // 
            // radDisplacementPik
            // 
            this.radDisplacementPik.AutoSize = true;
            this.radDisplacementPik.Location = new System.Drawing.Point(49, 45);
            this.radDisplacementPik.Name = "radDisplacementPik";
            this.radDisplacementPik.Size = new System.Drawing.Size(45, 17);
            this.radDisplacementPik.TabIndex = 10;
            this.radDisplacementPik.Text = "Пик";
            this.radDisplacementPik.UseVisualStyleBackColor = true;
            this.radDisplacementPik.CheckedChanged += new System.EventHandler(this.radDisplacementPik_CheckedChanged);
            // 
            // radDisplacementRMS
            // 
            this.radDisplacementRMS.AutoSize = true;
            this.radDisplacementRMS.Checked = true;
            this.radDisplacementRMS.Location = new System.Drawing.Point(6, 45);
            this.radDisplacementRMS.Name = "radDisplacementRMS";
            this.radDisplacementRMS.Size = new System.Drawing.Size(46, 17);
            this.radDisplacementRMS.TabIndex = 9;
            this.radDisplacementRMS.TabStop = true;
            this.radDisplacementRMS.Text = "СКЗ";
            this.radDisplacementRMS.UseVisualStyleBackColor = true;
            this.radDisplacementRMS.CheckedChanged += new System.EventHandler(this.radDisplacementRMS_CheckedChanged);
            // 
            // TDisplacement
            // 
            this.TDisplacement.Location = new System.Drawing.Point(6, 19);
            this.TDisplacement.Name = "TDisplacement";
            this.TDisplacement.Size = new System.Drawing.Size(86, 20);
            this.TDisplacement.TabIndex = 7;
            this.TDisplacement.TextChanged += new System.EventHandler(this.TDisplacement_TextChanged);
            // 
            // TDisplacement_dB
            // 
            this.TDisplacement_dB.Location = new System.Drawing.Point(210, 21);
            this.TDisplacement_dB.Name = "TDisplacement_dB";
            this.TDisplacement_dB.Size = new System.Drawing.Size(89, 20);
            this.TDisplacement_dB.TabIndex = 7;
            this.TDisplacement_dB.TextChanged += new System.EventHandler(this.TDisplacement_dB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Перемещение, дБ";
            // 
            // gBVelocity
            // 
            this.gBVelocity.Controls.Add(this.radVelocityPikPik);
            this.gBVelocity.Controls.Add(this.radVelocityPik);
            this.gBVelocity.Controls.Add(this.radVelocityRMS);
            this.gBVelocity.Controls.Add(this.TVelocity);
            this.gBVelocity.Controls.Add(this.TVelocity_dB);
            this.gBVelocity.Controls.Add(this.label8);
            this.gBVelocity.Location = new System.Drawing.Point(31, 190);
            this.gBVelocity.Name = "gBVelocity";
            this.gBVelocity.Size = new System.Drawing.Size(353, 72);
            this.gBVelocity.TabIndex = 12;
            this.gBVelocity.TabStop = false;
            this.gBVelocity.Text = "Скорость, мм/с";
            // 
            // radVelocityPikPik
            // 
            this.radVelocityPikPik.AutoSize = true;
            this.radVelocityPikPik.Location = new System.Drawing.Point(92, 45);
            this.radVelocityPikPik.Name = "radVelocityPikPik";
            this.radVelocityPikPik.Size = new System.Drawing.Size(63, 17);
            this.radVelocityPikPik.TabIndex = 10;
            this.radVelocityPikPik.Text = "Размах";
            this.radVelocityPikPik.UseVisualStyleBackColor = true;
            this.radVelocityPikPik.CheckedChanged += new System.EventHandler(this.radVelocityPikPik_CheckedChanged);
            // 
            // radVelocityPik
            // 
            this.radVelocityPik.AutoSize = true;
            this.radVelocityPik.Location = new System.Drawing.Point(49, 45);
            this.radVelocityPik.Name = "radVelocityPik";
            this.radVelocityPik.Size = new System.Drawing.Size(45, 17);
            this.radVelocityPik.TabIndex = 10;
            this.radVelocityPik.Text = "Пик";
            this.radVelocityPik.UseVisualStyleBackColor = true;
            this.radVelocityPik.CheckedChanged += new System.EventHandler(this.radVelocityPik_CheckedChanged);
            // 
            // radVelocityRMS
            // 
            this.radVelocityRMS.AutoSize = true;
            this.radVelocityRMS.Checked = true;
            this.radVelocityRMS.Location = new System.Drawing.Point(6, 45);
            this.radVelocityRMS.Name = "radVelocityRMS";
            this.radVelocityRMS.Size = new System.Drawing.Size(46, 17);
            this.radVelocityRMS.TabIndex = 9;
            this.radVelocityRMS.TabStop = true;
            this.radVelocityRMS.Text = "СКЗ";
            this.radVelocityRMS.UseVisualStyleBackColor = true;
            this.radVelocityRMS.CheckedChanged += new System.EventHandler(this.radVelocityRMS_CheckedChanged);
            // 
            // TVelocity
            // 
            this.TVelocity.Location = new System.Drawing.Point(6, 19);
            this.TVelocity.Name = "TVelocity";
            this.TVelocity.Size = new System.Drawing.Size(86, 20);
            this.TVelocity.TabIndex = 7;
            this.TVelocity.TextChanged += new System.EventHandler(this.TVelocity_TextChanged);
            // 
            // TVelocity_dB
            // 
            this.TVelocity_dB.Location = new System.Drawing.Point(210, 19);
            this.TVelocity_dB.Name = "TVelocity_dB";
            this.TVelocity_dB.Size = new System.Drawing.Size(89, 20);
            this.TVelocity_dB.TabIndex = 7;
            this.TVelocity_dB.TextChanged += new System.EventHandler(this.TVelocity_dB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Скорость,  дБ";
            // 
            // gBAcceleration
            // 
            this.gBAcceleration.Controls.Add(this.radAccelerationPikPik);
            this.gBAcceleration.Controls.Add(this.radAccelerationPik);
            this.gBAcceleration.Controls.Add(this.radAccelerationRMS);
            this.gBAcceleration.Controls.Add(this.TAcceleration);
            this.gBAcceleration.Controls.Add(this.TAcceleration_dB);
            this.gBAcceleration.Controls.Add(this.label4);
            this.gBAcceleration.Location = new System.Drawing.Point(31, 112);
            this.gBAcceleration.Name = "gBAcceleration";
            this.gBAcceleration.Size = new System.Drawing.Size(353, 72);
            this.gBAcceleration.TabIndex = 12;
            this.gBAcceleration.TabStop = false;
            this.gBAcceleration.Text = "Ускорение, м/с²";
            // 
            // radAccelerationPikPik
            // 
            this.radAccelerationPikPik.AutoSize = true;
            this.radAccelerationPikPik.Location = new System.Drawing.Point(92, 45);
            this.radAccelerationPikPik.Name = "radAccelerationPikPik";
            this.radAccelerationPikPik.Size = new System.Drawing.Size(63, 17);
            this.radAccelerationPikPik.TabIndex = 10;
            this.radAccelerationPikPik.Text = "Размах";
            this.radAccelerationPikPik.UseVisualStyleBackColor = true;
            this.radAccelerationPikPik.CheckedChanged += new System.EventHandler(this.radAccelerationPikPik_CheckedChanged);
            // 
            // radAccelerationPik
            // 
            this.radAccelerationPik.AutoSize = true;
            this.radAccelerationPik.Location = new System.Drawing.Point(49, 45);
            this.radAccelerationPik.Name = "radAccelerationPik";
            this.radAccelerationPik.Size = new System.Drawing.Size(45, 17);
            this.radAccelerationPik.TabIndex = 10;
            this.radAccelerationPik.Text = "Пик";
            this.radAccelerationPik.UseVisualStyleBackColor = true;
            this.radAccelerationPik.CheckedChanged += new System.EventHandler(this.radAccelerationPik_CheckedChanged);
            // 
            // radAccelerationRMS
            // 
            this.radAccelerationRMS.AutoSize = true;
            this.radAccelerationRMS.Checked = true;
            this.radAccelerationRMS.Location = new System.Drawing.Point(6, 45);
            this.radAccelerationRMS.Name = "radAccelerationRMS";
            this.radAccelerationRMS.Size = new System.Drawing.Size(46, 17);
            this.radAccelerationRMS.TabIndex = 9;
            this.radAccelerationRMS.TabStop = true;
            this.radAccelerationRMS.Text = "СКЗ";
            this.radAccelerationRMS.UseVisualStyleBackColor = true;
            this.radAccelerationRMS.CheckedChanged += new System.EventHandler(this.radAccelerationRMS_CheckedChanged);
            // 
            // TAcceleration
            // 
            this.TAcceleration.Location = new System.Drawing.Point(6, 19);
            this.TAcceleration.Name = "TAcceleration";
            this.TAcceleration.Size = new System.Drawing.Size(86, 20);
            this.TAcceleration.TabIndex = 7;
            this.TAcceleration.TextChanged += new System.EventHandler(this.TAcceleration_TextChanged);
            // 
            // TAcceleration_dB
            // 
            this.TAcceleration_dB.Location = new System.Drawing.Point(210, 19);
            this.TAcceleration_dB.Name = "TAcceleration_dB";
            this.TAcceleration_dB.Size = new System.Drawing.Size(89, 20);
            this.TAcceleration_dB.TabIndex = 7;
            this.TAcceleration_dB.TextChanged += new System.EventHandler(this.TAcceleration_dB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ускорение,  дБ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBDisplacement.ResumeLayout(false);
            this.GBDisplacement.PerformLayout();
            this.gBVelocity.ResumeLayout(false);
            this.gBVelocity.PerformLayout();
            this.gBAcceleration.ResumeLayout(false);
            this.gBAcceleration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private ModifiedTextBox TSensitivity;
        private System.Windows.Forms.RadioButton radSensitivityM;
        private System.Windows.Forms.RadioButton radSensitivityG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radFrequencyRPM;
        private System.Windows.Forms.RadioButton radFrequencyHw;
        private ModifiedTextBox TFrequency;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radVoltagePikPik;
        private System.Windows.Forms.RadioButton radVoltagePik;
        private System.Windows.Forms.RadioButton radVoltageRMS;
        private ModifiedTextBox TVoltage;
        private ModifiedTextBox TVoltage_dB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDispSensFreq;
        private System.Windows.Forms.RadioButton radVelSensFreq;
        private System.Windows.Forms.RadioButton radAccSensFreq;
        private System.Windows.Forms.GroupBox GBDisplacement;
        private System.Windows.Forms.RadioButton radiDisplacementPikPik;
        private System.Windows.Forms.RadioButton radDisplacementPik;
        private System.Windows.Forms.RadioButton radDisplacementRMS;
        private ModifiedTextBox TDisplacement;
        private ModifiedTextBox TDisplacement_dB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gBVelocity;
        private System.Windows.Forms.RadioButton radVelocityPikPik;
        private System.Windows.Forms.RadioButton radVelocityPik;
        private System.Windows.Forms.RadioButton radVelocityRMS;
        private ModifiedTextBox TVelocity;
        private ModifiedTextBox TVelocity_dB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gBAcceleration;
        private System.Windows.Forms.RadioButton radAccelerationPikPik;
        private System.Windows.Forms.RadioButton radAccelerationPik;
        private System.Windows.Forms.RadioButton radAccelerationRMS;
        private ModifiedTextBox TAcceleration;
        private ModifiedTextBox TAcceleration_dB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radVoltSensFreq;
    }
}

