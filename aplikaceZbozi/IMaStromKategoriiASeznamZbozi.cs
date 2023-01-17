namespace aplikaceZbozi
{
    //Pomocné rozhraní, aby okno se zbožím mohlo lépe spolupracovat s obchodem a historií koupeného zboží
    interface IMaStromKategoriiASeznamZbozi
    {
        StromKategorii stromKategorii { get; set; }
        System.Windows.Forms.FlowLayoutPanel flpSeznamZbozi { get; set; }
        void OtevriPredchozi();
    }
}
