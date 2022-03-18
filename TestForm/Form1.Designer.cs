namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lBtnClickThis = new System.Windows.Forms.Label();
            this.legOneBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.legTwoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            resources.ApplyResources(this.btnClickThis, "btnClickThis");
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lBtnClickThis
            // 
            resources.ApplyResources(this.lBtnClickThis, "lBtnClickThis");
            this.lBtnClickThis.Name = "lBtnClickThis";
            // 
            // legOneBox
            // 
            resources.ApplyResources(this.legOneBox, "legOneBox");
            this.legOneBox.Name = "legOneBox";
            // 
            // resultBox
            // 
            resources.ApplyResources(this.resultBox, "resultBox");
            this.resultBox.Name = "resultBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // legTwoBox
            // 
            resources.ApplyResources(this.legTwoBox, "legTwoBox");
            this.legTwoBox.Name = "legTwoBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.legTwoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.legOneBox);
            this.Controls.Add(this.lBtnClickThis);
            this.Controls.Add(this.btnClickThis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lBtnClickThis;
        private System.Windows.Forms.TextBox legOneBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox legTwoBox;
        private System.Windows.Forms.Label label3;
    }
}

