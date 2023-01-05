﻿namespace BlazorApp1.Client.Services
{
    public interface IBananaService
    {
        public event Action OnChange;
        int Bananas { get; set; }

        void EatBananas(int amount);

        void AddBananas(int amount);
    }
}
