namespace ConceptsPOO
{
    public class Invoice : IPay
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public float Quatity { get; set; }

        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quatity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tQuantity.....: {$"{Quatity:N2}",15}" +
                $"\n\tPrice........: {$"{Price:C2}",15}" +
                $"\n\tValue.....: {$"{GetValueToPay():C2}",15}";
        }
    }
}
