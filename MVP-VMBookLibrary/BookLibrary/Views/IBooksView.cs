
﻿using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Views {
    public interface IBooksView {
        void FillBooks(IEnumerable<BookViewModel> bookViewModels);
    }
}