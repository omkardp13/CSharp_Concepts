namespace FacadeDesignPatter.Services
{
    public class PaymentService
    {
        public string ProcessPayment(decimal amount)
        {
            // Simulate payment processing logic
            return $"Payment of {amount:C} processed successfully.";
        }
    }

}
