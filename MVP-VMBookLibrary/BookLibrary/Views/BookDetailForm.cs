
﻿using BookLibrary.Presenters;
using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary.Views {
    public partial class BookDetailForm : Form, IBookDetailView {

        private readonly BookDetailPresenter _presenter;

        public BookDetailForm(BookViewModel bookViewModel) {
            InitializeComponent();

            _presenter = new BookDetailPresenter(this, bookViewModel);
        }

        public void SetCurrentBook(BookViewModel model) {
            bookBindingSource.DataSource = model;
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            _presenter.Cancel();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            _presenter.SaveBook();
        }
    }
}