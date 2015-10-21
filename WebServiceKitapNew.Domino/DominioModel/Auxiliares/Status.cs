namespace WebServiceKitapNew.Dominio.DominioModel.Auxiliares
{
    public class Status
    {
        public static string Disponivel {  get{ return "Disponivel"; } }
        public static string Indisponivel { get { return "Indisponivel"; } }
        public static string Pedido { get { return "Pedido"; } }
        public static string Emprestado { get { return "Emprestado"; } }
        public static string Finalizado { get { return "Finalizado"; } }
        public static string Andamento { get { return "Andamento"; } }
        public static string Confirmado { get { return "Confirmado"; } }
        public static string Cancelado { get { return "Cancelado"; } }
        public static string Negado { get { return "Negado"; } }
    }
}