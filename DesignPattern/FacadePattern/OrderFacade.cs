using FacadeDesignPatter.Services;

namespace FacadeDesignPatter
{
    public class OrderFacade
    {
        private readonly AuthenticationService _authService;
        private readonly OrderService _orderService;
        private readonly PaymentService _paymentService;
        private readonly NotificationService _notificationService;

        public OrderFacade(
            AuthenticationService authService,
            OrderService orderService,
            PaymentService paymentService,
            NotificationService notificationService)
        {
            _authService = authService;
            _orderService = orderService;
            _paymentService = paymentService;
            _notificationService = notificationService;
        }

        public string PlaceOrder(string username, string password, int orderId, decimal amount)
        {
            if (!_authService.Authenticate(username, password))
            {
                return "Authentication failed.";
            }

            var orderResult = _orderService.ProcessOrder(orderId);
            var paymentResult = _paymentService.ProcessPayment(amount);

            _notificationService.SendNotification($"Order {orderId} placed successfully.");

            return $"{orderResult} {paymentResult}";
        }
    }

}
