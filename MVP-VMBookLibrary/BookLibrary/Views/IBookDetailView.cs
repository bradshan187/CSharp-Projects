﻿
﻿using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Views {
    public interface IBookDetailView {
        void SetCurrentBook(BookViewModel model);

        void ShowError(string message);
        void Close();
    }
}