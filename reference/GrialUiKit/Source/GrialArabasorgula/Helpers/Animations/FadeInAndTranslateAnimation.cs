/* [grial-metadata] id: Grial#FadeInAndTranslateAnimation.cs version: 1.0.3 */
using UXDivers.Grial.Animations;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FadeInAndTranslateAnimation : BaseAnimation
    {
        public static readonly BindableProperty InitialTranslationYProperty =
            BindableProperty.Create(
                nameof(InitialTranslationY),
                typeof(double),
                typeof(FadeInAndTranslateAnimation),
                defaultValue: 0d);

        public double InitialTranslationY
        {
            get { return (double)GetValue(InitialTranslationYProperty); }
            set { SetValue(InitialTranslationYProperty, value); }
        }

        public Animation FadeIn()
        {
            var animation = new Animation();

            animation.WithConcurrent(f => Target.Opacity = f, 0, 1, Microsoft.Maui.Easing.CubicOut);

            animation.WithConcurrent(
              f => Target.TranslationY = f,
              Target.TranslationY + InitialTranslationY,
              Target.TranslationY,
              Microsoft.Maui.Easing.CubicOut,
              0,
              1);

            return animation;
        }

        public override BaseAnimation ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        protected override Task StartAnimation(VisualElement reentrantTarget)
        {
            Console.WriteLine("HOLA");
            return Task.Run(() =>
            {
                Application.Current.Dispatcher.Dispatch(() =>
                {
                    reentrantTarget.Animate("FadeIn", FadeIn(), 16, Convert.ToUInt32(Duration));
                });
            });
        }
    }
}
