
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Repositories {
    public interface IBookRepository {
        void LoadBooksFromFile();
        void SaveBooksToFile();
    }
}