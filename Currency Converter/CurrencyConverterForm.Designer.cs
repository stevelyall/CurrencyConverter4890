namespace Currency_Converter
{
 partial class CurrencyConverterForm
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
   this.amountInput = new System.Windows.Forms.TextBox();
   this.usdInputLabel = new System.Windows.Forms.Label();
   this.equivalentInLabel = new System.Windows.Forms.Label();
   this.resultLabel = new System.Windows.Forms.Label();
   this.targetCurrencyGroupBox = new System.Windows.Forms.GroupBox();
   this.japanRadio = new System.Windows.Forms.RadioButton();
   this.europeanRadio = new System.Windows.Forms.RadioButton();
   this.canadaRadio = new System.Windows.Forms.RadioButton();
   this.brazilRadio = new System.Windows.Forms.RadioButton();
   this.computeButton = new System.Windows.Forms.Button();
   this.clearButton = new System.Windows.Forms.Button();
   this.quitButton = new System.Windows.Forms.Button();
   this.rateSourceLabel = new System.Windows.Forms.Label();
   this.targetCurrencyGroupBox.SuspendLayout();
   this.SuspendLayout();
   // 
   // amountInput
   // 
   this.amountInput.Location = new System.Drawing.Point(250, 45);
   this.amountInput.Name = "amountInput";
   this.amountInput.Size = new System.Drawing.Size(127, 26);
   this.amountInput.TabIndex = 0;
   // 
   // usdInputLabel
   // 
   this.usdInputLabel.AutoSize = true;
   this.usdInputLabel.Location = new System.Drawing.Point(59, 50);
   this.usdInputLabel.Name = "usdInputLabel";
   this.usdInputLabel.Size = new System.Drawing.Size(143, 20);
   this.usdInputLabel.TabIndex = 1;
   this.usdInputLabel.Text = "U.S. Dollar amount";
   // 
   // equivalentInLabel
   // 
   this.equivalentInLabel.AutoSize = true;
   this.equivalentInLabel.Location = new System.Drawing.Point(63, 94);
   this.equivalentInLabel.Name = "equivalentInLabel";
   this.equivalentInLabel.Size = new System.Drawing.Size(115, 20);
   this.equivalentInLabel.TabIndex = 2;
   this.equivalentInLabel.Text = "Equivalent in ...";
   // 
   // resultLabel
   // 
   this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.resultLabel.Location = new System.Drawing.Point(250, 94);
   this.resultLabel.Name = "resultLabel";
   this.resultLabel.Size = new System.Drawing.Size(127, 23);
   this.resultLabel.TabIndex = 1;
   // 
   // targetCurrencyGroupBox
   // 
   this.targetCurrencyGroupBox.Controls.Add(this.japanRadio);
   this.targetCurrencyGroupBox.Controls.Add(this.europeanRadio);
   this.targetCurrencyGroupBox.Controls.Add(this.canadaRadio);
   this.targetCurrencyGroupBox.Controls.Add(this.brazilRadio);
   this.targetCurrencyGroupBox.Location = new System.Drawing.Point(50, 155);
   this.targetCurrencyGroupBox.Name = "targetCurrencyGroupBox";
   this.targetCurrencyGroupBox.Size = new System.Drawing.Size(200, 171);
   this.targetCurrencyGroupBox.TabIndex = 4;
   this.targetCurrencyGroupBox.TabStop = false;
   // 
   // japanRadio
   // 
   this.japanRadio.AutoSize = true;
   this.japanRadio.Location = new System.Drawing.Point(17, 119);
   this.japanRadio.Name = "japanRadio";
   this.japanRadio.Size = new System.Drawing.Size(78, 24);
   this.japanRadio.TabIndex = 5;
   this.japanRadio.TabStop = true;
   this.japanRadio.Text = "Japan";
   this.japanRadio.UseVisualStyleBackColor = true;
   // 
   // europeanRadio
   // 
   this.europeanRadio.AutoSize = true;
   this.europeanRadio.Location = new System.Drawing.Point(17, 87);
   this.europeanRadio.Name = "europeanRadio";
   this.europeanRadio.Size = new System.Drawing.Size(184, 24);
   this.europeanRadio.TabIndex = 4;
   this.europeanRadio.TabStop = true;
   this.europeanRadio.Text = "European community";
   this.europeanRadio.UseVisualStyleBackColor = true;
   // 
   // canadaRadio
   // 
   this.canadaRadio.AutoSize = true;
   this.canadaRadio.Location = new System.Drawing.Point(17, 57);
   this.canadaRadio.Name = "canadaRadio";
   this.canadaRadio.Size = new System.Drawing.Size(90, 24);
   this.canadaRadio.TabIndex = 3;
   this.canadaRadio.TabStop = true;
   this.canadaRadio.Text = "Canada";
   this.canadaRadio.UseVisualStyleBackColor = true;
   // 
   // brazilRadio
   // 
   this.brazilRadio.AutoSize = true;
   this.brazilRadio.Location = new System.Drawing.Point(17, 26);
   this.brazilRadio.Name = "brazilRadio";
   this.brazilRadio.Size = new System.Drawing.Size(73, 24);
   this.brazilRadio.TabIndex = 2;
   this.brazilRadio.TabStop = true;
   this.brazilRadio.Text = "Brazil";
   this.brazilRadio.UseVisualStyleBackColor = true;
   // 
   // computeButton
   // 
   this.computeButton.Location = new System.Drawing.Point(306, 176);
   this.computeButton.Name = "computeButton";
   this.computeButton.Size = new System.Drawing.Size(114, 36);
   this.computeButton.TabIndex = 6;
   this.computeButton.Text = "&Compute";
   this.computeButton.UseVisualStyleBackColor = true;
   this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
   // 
   // clearButton
   // 
   this.clearButton.Location = new System.Drawing.Point(306, 218);
   this.clearButton.Name = "clearButton";
   this.clearButton.Size = new System.Drawing.Size(114, 36);
   this.clearButton.TabIndex = 7;
   this.clearButton.Text = "C&lear";
   this.clearButton.UseVisualStyleBackColor = true;
   this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
   // 
   // quitButton
   // 
   this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.quitButton.Location = new System.Drawing.Point(306, 260);
   this.quitButton.Name = "quitButton";
   this.quitButton.Size = new System.Drawing.Size(114, 36);
   this.quitButton.TabIndex = 8;
   this.quitButton.Text = "&Quit";
   this.quitButton.UseVisualStyleBackColor = true;
   this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
   // 
   // rateSourceLabel
   // 
   this.rateSourceLabel.AutoSize = true;
   this.rateSourceLabel.Location = new System.Drawing.Point(18, 345);
   this.rateSourceLabel.Name = "rateSourceLabel";
   this.rateSourceLabel.Size = new System.Drawing.Size(127, 20);
   this.rateSourceLabel.TabIndex = 9;
   this.rateSourceLabel.Text = "rateSourceLabel";
   // 
   // CurrencyConverterForm
   // 
   this.AcceptButton = this.computeButton;
   this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.CancelButton = this.quitButton;
   this.ClientSize = new System.Drawing.Size(479, 374);
   this.Controls.Add(this.rateSourceLabel);
   this.Controls.Add(this.quitButton);
   this.Controls.Add(this.clearButton);
   this.Controls.Add(this.computeButton);
   this.Controls.Add(this.targetCurrencyGroupBox);
   this.Controls.Add(this.resultLabel);
   this.Controls.Add(this.equivalentInLabel);
   this.Controls.Add(this.usdInputLabel);
   this.Controls.Add(this.amountInput);
   this.Name = "CurrencyConverterForm";
   this.Text = "Currency Converter";
   this.Load += new System.EventHandler(this.CurrencyConverterForm_Load);
   this.targetCurrencyGroupBox.ResumeLayout(false);
   this.targetCurrencyGroupBox.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.TextBox amountInput;
  private System.Windows.Forms.Label usdInputLabel;
  private System.Windows.Forms.Label equivalentInLabel;
  private System.Windows.Forms.Label resultLabel;
  private System.Windows.Forms.GroupBox targetCurrencyGroupBox;
  private System.Windows.Forms.RadioButton japanRadio;
  private System.Windows.Forms.RadioButton europeanRadio;
  private System.Windows.Forms.RadioButton canadaRadio;
  private System.Windows.Forms.RadioButton brazilRadio;
  private System.Windows.Forms.Button computeButton;
  private System.Windows.Forms.Button clearButton;
  private System.Windows.Forms.Button quitButton;
  private System.Windows.Forms.Label rateSourceLabel;
 }
}

