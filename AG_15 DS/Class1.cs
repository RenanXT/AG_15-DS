namespace AG_15_DS
{
    public class Class1
    {
       

        public class cadastro
        {
            public String DESCRICAO { get; set; }
            public DateTime INICIO { get; set; }
            public DateTime FINAL { get; set; }
            public int QUANTIDADE { get; set; }
            public string LOCALIZACAO { get; set; }
           
            public int ValorTotal
            {
                get
                {
                    TimeSpan diferenca = FINAL - INICIO;
                    int TempoEvento = diferenca.Days;
                    return QUANTIDADE * 50 + (TempoEvento * 30);
                }
            }
        }
    }
}
