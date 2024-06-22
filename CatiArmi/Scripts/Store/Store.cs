﻿namespace CatiArmi.Scripts
{
    public class Store
    {
        public string Name;
        public string DisplayName;
        public string Icon;
        public int PachisToUnlock;

        public List<StoreItem> ItemsForSale;

        public string CurSpeech = "";
        public List<string> SpeechGreetings;
        public List<string> SpeechPurchased;
        public List<string> SpeechCantAfford;
        public List<string> SpeechFullResource;
        public List<string> SpeechNoSpace;

        public bool IsShopAvailable()
        {
            return Inventory.GetTotalPachiCount() >= PachisToUnlock;
        }
    }
}
