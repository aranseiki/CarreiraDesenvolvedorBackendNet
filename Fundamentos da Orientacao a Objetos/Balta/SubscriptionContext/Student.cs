using Balta.SharedContext;
using Balta.NotificationContext;

namespace Balta.SubscriptionContext {
    public class Student: Base {
        public Student() {
            subscriptions = new List<Subscription>();
        }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? User { get; set; }
        public List<Subscription>? subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription) {
            if (IsPremium) {
                AddNotification(new Notification("Premium", "O aluno já tem assinatura ativa."));
                return;
            }

            subscriptions?.Add(subscription);
        }
        public bool IsPremium => subscriptions.Any(x=>x.IsInactive);
    }
}