namespace TextReader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CutRightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertRightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllRightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNextFindWord = new System.Windows.Forms.Button();
            this.buttonPrevFindWord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Enabled = false;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(893, 27);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(33, 33);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Enabled = false;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(892, 66);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(33, 33);
            this.buttonMinus.TabIndex = 6;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFind.Enabled = false;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFind.Image = ((System.Drawing.Image)(resources.GetObject("buttonFind.Image")));
            this.buttonFind.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFind.Location = new System.Drawing.Point(893, 105);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(33, 33);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(13, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(874, 480);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutRightClickToolStripMenuItem,
            this.CopyRightClickToolStripMenuItem,
            this.InsertRightClickToolStripMenuItem,
            this.SelectAllRightClickToolStripMenuItem,
            this.DeleteRightClickToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // CutRightClickToolStripMenuItem
            // 
            this.CutRightClickToolStripMenuItem.Enabled = false;
            this.CutRightClickToolStripMenuItem.Name = "CutRightClickToolStripMenuItem";
            this.CutRightClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CutRightClickToolStripMenuItem.Text = "Вырезать";
            this.CutRightClickToolStripMenuItem.Click += new System.EventHandler(this.CutRightClickToolStripMenuItem_Click);
            // 
            // CopyRightClickToolStripMenuItem
            // 
            this.CopyRightClickToolStripMenuItem.Enabled = false;
            this.CopyRightClickToolStripMenuItem.Name = "CopyRightClickToolStripMenuItem";
            this.CopyRightClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyRightClickToolStripMenuItem.Text = "Копировать";
            this.CopyRightClickToolStripMenuItem.Click += new System.EventHandler(this.CopyRightClickToolStripMenuItem_Click);
            // 
            // InsertRightClickToolStripMenuItem
            // 
            this.InsertRightClickToolStripMenuItem.Enabled = false;
            this.InsertRightClickToolStripMenuItem.Name = "InsertRightClickToolStripMenuItem";
            this.InsertRightClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InsertRightClickToolStripMenuItem.Text = "Вставить";
            this.InsertRightClickToolStripMenuItem.Click += new System.EventHandler(this.InsertRightClickToolStripMenuItem_Click);
            // 
            // SelectAllRightClickToolStripMenuItem
            // 
            this.SelectAllRightClickToolStripMenuItem.Enabled = false;
            this.SelectAllRightClickToolStripMenuItem.Name = "SelectAllRightClickToolStripMenuItem";
            this.SelectAllRightClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SelectAllRightClickToolStripMenuItem.Text = "Выделить все";
            this.SelectAllRightClickToolStripMenuItem.Click += new System.EventHandler(this.SelectAllRightClickToolStripMenuItem_Click);
            // 
            // DeleteRightClickToolStripMenuItem
            // 
            this.DeleteRightClickToolStripMenuItem.Enabled = false;
            this.DeleteRightClickToolStripMenuItem.Name = "DeleteRightClickToolStripMenuItem";
            this.DeleteRightClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteRightClickToolStripMenuItem.Text = "Удалить";
            this.DeleteRightClickToolStripMenuItem.Click += new System.EventHandler(this.DeleteRightClickToolStripMenuItem_Click);
            // 
            // buttonNextFindWord
            // 
            this.buttonNextFindWord.Enabled = false;
            this.buttonNextFindWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextFindWord.Location = new System.Drawing.Point(893, 144);
            this.buttonNextFindWord.Name = "buttonNextFindWord";
            this.buttonNextFindWord.Size = new System.Drawing.Size(33, 33);
            this.buttonNextFindWord.TabIndex = 9;
            this.buttonNextFindWord.Text = ">>";
            this.buttonNextFindWord.UseVisualStyleBackColor = true;
            this.buttonNextFindWord.Click += new System.EventHandler(this.buttonNextFindWord_Click);
            // 
            // buttonPrevFindWord
            // 
            this.buttonPrevFindWord.Enabled = false;
            this.buttonPrevFindWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrevFindWord.Location = new System.Drawing.Point(893, 183);
            this.buttonPrevFindWord.Name = "buttonPrevFindWord";
            this.buttonPrevFindWord.Size = new System.Drawing.Size(33, 33);
            this.buttonPrevFindWord.TabIndex = 10;
            this.buttonPrevFindWord.Text = "<<";
            this.buttonPrevFindWord.UseVisualStyleBackColor = true;
            this.buttonPrevFindWord.Click += new System.EventHandler(this.buttonPrevFindWord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Enabled = false;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem1,
            this.InsertToolStripMenuItem,
            this.SelectAllToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.UndoToolStripMenuItem.Text = "Отменить";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem1
            // 
            this.CopyToolStripMenuItem1.Enabled = false;
            this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
            this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.CopyToolStripMenuItem1.Text = "Копировать";
            this.CopyToolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Enabled = false;
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.InsertToolStripMenuItem.Text = "Вставить";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Enabled = false;
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SelectAllToolStripMenuItem.Text = "Выделить все";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 519);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonPrevFindWord);
            this.Controls.Add(this.buttonNextFindWord);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonNextFindWord;
        private System.Windows.Forms.Button buttonPrevFindWord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyRightClickToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutRightClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertRightClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllRightClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteRightClickToolStripMenuItem;
    }
}

