﻿using CardGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Interfaces
{
    public interface IDeckService<T> : IDisposable 
        where T : ICard
    {
        T GetTopCard();
        void Shuffle();
        void ResetDeck(Stack<T> cards);
        int GetCount();

    }
}
