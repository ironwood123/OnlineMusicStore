﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Models;
namespace MusicStore.Service
{
    public interface IGenreService
    {
        IEnumerable<Genre> ListGenre();
        Genre GetGenreById(int Id);
    }
}
