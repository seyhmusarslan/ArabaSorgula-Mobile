using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using arabasorgula.Resx;
using UXDivers.Grial;

namespace arabasorgula
{
    public enum FlowType
    {
        Chat,
        Ecommerce,
        Movies,
        Tasks,
        Map,
        Explorer,
        SmartHome,
        News,
        Quiz,
        Wizard
    }

    public static class SamplesCatalog
    {
        private static CultureChangeNotifier _notifier;

        private static List<SampleCategory> _samplesCategoryList;
        private static List<FlowSample> _flows;

        public static List<SampleCategory> SamplesCategoryList
        {
            get
            {
                if (_samplesCategoryList == null)
                {
                    _samplesCategoryList = CreateSamples();
                }

                return _samplesCategoryList;
            }
        }


        public static List<FlowSample> Flows
        {
            get
            {
                if (_flows == null)
                {
                    _flows = CreateFlows();
                }

                return _flows;
            }
        }


        public static void Initialize()
        {
            _notifier = new CultureChangeNotifier();
            _notifier.CultureChanged += (sender, args) => InitializeData();
        }

        public static void InitializeData()
        {
            _flows = null;
            _samplesCategoryList = null;

        }


        public static List<FlowSample> CreateFlows()
        {
            return new List<FlowSample>
            {
                new FlowSample(
                    AppResources.FlowTitleTasks,
                    DemoAppResources.FlowDescriptionTasks,
                    GrialIconsFont.Dashboard,
                    Color.FromArgb("#39E492"),
                    Color.FromArgb("#01AB97"),
                    typeof(PerformanceDashboardNavigationPage),
                    FlowType.Tasks)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitlePerformanceDashboardMain,
                            DemoAppResources.PerformanceDashboardMainPageDescription,
                            GrialIconsFont.Clipboard,
                            typeof(PerformanceDashboardMainPage)),
                        new Sample(
                            AppResources.PageTitleEmployeePerformanceDashboard,
                            DemoAppResources.EmployeePerformanceDashboardPageDescription,
                            GrialIconsFont.Clipboard,
                            typeof(EmployeePerformanceDashboardPage)),
                        new Sample(
                            AppResources.PageTitleEmployeeProfileDashboard,
                            DemoAppResources.EmployeeProfileDashboardPageDescription,
                            GrialIconsFont.Clipboard,
                            typeof(EmployeeProfileDashboardPage))
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleQuiz,
                    DemoAppResources.FlowDescriptionQuiz,
                    GrialIconsFont.Gamepad,
                    Color.FromArgb("#3F97FF"),
                    Color.FromArgb("#3F75FF"),
                    null,
                    FlowType.Quiz)
                {
                    ShowInMainCarousel = true,
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleQuizDashboard,
                            DemoAppResources.QuizDashboardPageDescription,
                            GrialIconsFont.Sidebar,
                            typeof(QuizDashboardPage)),
                        new Sample(
                            AppResources.PageTitleQuizGame,
                            DemoAppResources.QuizGamePageDescription,
                            GrialIconsFont.Gamepad,
                            typeof(QuizGamePage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleQuizResults,
                            DemoAppResources.QuizResultsPageDescription,
                            GrialIconsFont.Thermometer,
                            typeof(QuizResultsPage))
                        {
                           IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleQuizProfileAchievements,
                            DemoAppResources.QuizProfileAchievementsPageDescription,
                            GrialIconsFont.PieChart,
                            typeof(QuizProfileAchievementsPage)),
                    }
                },
                new FlowSample(
                    "News Flow",
                    "Discover the latest news through a nice feed, read article previews for a quick overview, and dive into full articles for in-depth information.",
                    GrialIconsFont.FileText,
                    Color.FromArgb("#39E492"),
                    Color.FromArgb("#01AB97"),
                    null,
                    FlowType.News)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            "Welcome Page",
                            DemoAppResources.NewsWelcomePageDescription,
                            GrialIconsFont.Carousel,
                            typeof(NewsWelcomePage)),
                        new Sample(
                            "Login Page",
                            DemoAppResources.NewsLoginPageDescription,
                            GrialIconsFont.Edit3,
                            typeof(NewsLoginPage)),
                        new Sample(
                            "Signup Page",
                            DemoAppResources.NewsSignUpPageDescription,
                            GrialIconsFont.Edit3,
                            typeof(NewsSignUpPage)),
                        new Sample(
                            "Main Page",
                            DemoAppResources.NewsMainPageDescription,
                            GrialIconsFont.Menu,
                            typeof(NewsMainPage)),
                         new Sample(
                            "Membership Page",
                            DemoAppResources.NewsMembershipPageDescription,
                            GrialIconsFont.Award,
                            typeof(NewsMembershipPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            "News List Page",
                            DemoAppResources.NewsListPageDescription,
                            GrialIconsFont.List,
                            typeof(NewsListPage)),
                        new Sample(
                            "Sources Page",
                            DemoAppResources.NewsSourcesPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(NewsSourcesPage)),
                        new Sample(
                            "Topics Page",
                            DemoAppResources.NewsTopicsPageDescription,
                            GrialIconsFont.List,
                            typeof(NewsTopicsPage)),
                        new Sample(
                            "Source Profile Page",
                            DemoAppResources.NewsSourceProfilePageDescription,
                            GrialIconsFont.Book,
                            typeof(NewsSourceProfilePage)),
                        new Sample(
                            "Detail Page",
                            DemoAppResources.NewsDetailPageDescription,
                            GrialIconsFont.BookOpen,
                            typeof(NewsDetailPage)),
                        new Sample(
                            "My Profile Page",
                            DemoAppResources.NewsMyProfilePageDescription,
                            GrialIconsFont.User,
                            typeof(NewsMyProfilePage))
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleSmartHome,
                    DemoAppResources.FlowDescriptionSmartHome,
                    GrialIconsFont.Tv,
                    Color.FromArgb("#39E492"),
                    Color.FromArgb("#01AB97"),
                    typeof(SmartHomeNavigationPage),
                    FlowType.SmartHome)
                {
                    ShowInMainCarousel = true,
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleSmartHomeMain,
                            DemoAppResources.SmartHomeMainPageDescription,
                            GrialIconsFont.Tv,
                            typeof(SmartHomeMainPage)),
                        new Sample(
                            AppResources.PageTitleSmartHomeRoom,
                            DemoAppResources.SmartHomeRoomPageDescription,
                            GrialIconsFont.Tv,
                            typeof(SmartHomeRoomPage)),
                        new Sample(
                            AppResources.PageTitleSmartHomeLightSettings,
                            DemoAppResources.SmartHomeLightSettingsPageDescription,
                            GrialIconsFont.Power,
                            typeof(SmartHomeLightSettingsPage)),
                         new Sample(
                            AppResources.PageTitleSmartHomeACSettings,
                            DemoAppResources.SmartHomeLightSettingsPageDescription,
                            GrialIconsFont.Thermometer,
                            typeof(SmartHomeAirSettingsPage))
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleWizard,
                    DemoAppResources.FlowDescriptionWizard,
                    GrialIconsFont.Carousel,
                    Color.FromArgb("#E85A5A"),
                    Color.FromArgb("#FF2525"),
                    typeof(WizardNavigationPage),
                    FlowType.Wizard)
                {
                    ShowInMainCarousel = true,
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleWizardMain,
                            DemoAppResources.WizardMainPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WizardMainPage)),
                        new Sample(
                            AppResources.PageTitleWizardVariantMain,
                            DemoAppResources.WizardVariantMainPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WizardVariantMainPage)),
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleMovies,
                    DemoAppResources.FlowDescriptionMovies,
                    GrialIconsFont.Film,
                    Color.FromArgb("#3F97FF"),
                    Color.FromArgb("#3F75FF"),
                    typeof(MoviesNavigationPage),
                    FlowType.Movies)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleMoviesMain,
                            DemoAppResources.MoviesMainPageDescription,
                            GrialIconsFont.Film,
                            typeof(MoviesMainPage)),
                        new Sample(
                            AppResources.PageTitleMovieDetail,
                            DemoAppResources.MovieDetailPageDescription,
                            GrialIconsFont.Film,
                            typeof(MovieDetailPage)),
                        new Sample(
                            AppResources.PageTitleFeaturedMovies,
                            DemoAppResources.FeaturedMoviesPageDescription,
                            GrialIconsFont.Film,
                            typeof(FeaturedMoviesPage))
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleEcommerce,
                    DemoAppResources.FlowDescriptionEcommerce,
                    GrialIconsFont.ShoppingCart,
                    Color.FromArgb("#E85A5A"),
                    Color.FromArgb("#FF2525"),
                    typeof(EcommerceNavigationPage),
                    FlowType.Ecommerce)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleEcommerceMain,
                            DemoAppResources.EcommerceMainPageDescription,
                            GrialIconsFont.ShoppingCart,
                            typeof(EcommerceMainPage)),
                        new Sample(
                            AppResources.PageTitleProductDetail,
                            DemoAppResources.ProductDetailPageDescription,
                            GrialIconsFont.ShoppingCart,
                            typeof(ProductDetailPage)),
                        new Sample(
                            AppResources.PageTitleOrderConfirmation,
                            DemoAppResources.OrderConfirmationPageDescription,
                            GrialIconsFont.ShoppingCart,
                            typeof(OrderConfirmationPage)),
                        new Sample(
                            AppResources.PageTitleCheckout,
                            DemoAppResources.CheckoutPageDescription,
                            GrialIconsFont.ShoppingCart,
                            typeof(CheckoutPage))
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleMessages,
                    DemoAppResources.FlowDescriptionMessages,
                    GrialIconsFont.MessagesSquare,
                    Color.FromArgb("#FF7455"),
                    Color.FromArgb("#E74B1A"),
                    typeof(ChatNavigationPage),
                    FlowType.Chat)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleChatMain,
                            DemoAppResources.ChatMainPageDescription,
                            GrialIconsFont.MessagesCircle,
                            typeof(ChatMainPage)),
                        new Sample(
                            AppResources.PageTitleChatMessages,
                            DemoAppResources.ChatMessagesPageDescription,
                            GrialIconsFont.MessagesCircle,
                            typeof(ChatMessagesPage)),
                        new Sample(
                            AppResources.PageTitleContactDetail,
                            DemoAppResources.ContactDetailPageDescription,
                            GrialIconsFont.User,
                            typeof(ContactDetailPage)),
                        new Sample(
                            AppResources.PageTitleAddContact,
                            DemoAppResources.AddContactPageDescription,
                            GrialIconsFont.UserPlus,
                            typeof(AddContactPage))
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleFoodPlaces,
                    DemoAppResources.FlowDescriptionFoodPlaces,
                    GrialIconsFont.Map,
                    Color.FromArgb("#39E492"),
                    Color.FromArgb("#01AB97"),
                    typeof(FoodPlacesNavigationPage),
                    FlowType.Map)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleFoodPlacesMain,
                            DemoAppResources.FoodPlacesMainPageDescription,
                            GrialIconsFont.List,
                            typeof(FoodPlacesMainPage)),
                        new Sample(
                            AppResources.PageTitleFoodPlacesMap,
                            DemoAppResources.FoodPlacesMapPageDescription,
                            GrialIconsFont.MapPin,
                            typeof(FoodPlacesMapPage)),
                        new Sample(
                            AppResources.PageTitleFoodPlacesDishReview,
                            DemoAppResources.FoodPlacesDishReviewPageDescription,
                            GrialIconsFont.StarFill,
                            typeof(FoodPlacesDishReviewPage))
                        {
                            IsModal = false
                        }
                    }
                },
                new FlowSample(
                    AppResources.FlowTitleExplorerFiles,
                    DemoAppResources.FlowDescriptionExplorerFiles,
                    GrialIconsFont.Folder,
                    Color.FromArgb("#E85A5A"),
                    Color.FromArgb("#FF2525"),
                    typeof(ExplorerFlowNavigationPage),
                    FlowType.Explorer)
                {
                    IndividualPages = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleExplorerList,
                            DemoAppResources.ExplorerListPageDescription,
                            GrialIconsFont.List,
                            typeof(ExplorerListPage)),
                    }
                }
            };
        }


        public static List<SampleCategory> CreateSamples()
        {
            return new List<SampleCategory>
            {

                
                new SampleCategory
                {
                    Id = 1,
                    Name = AppResources.StringCategoryFlows,
                    Description = AppResources.StringCategoryFlowsDescription,
                    Icon = GrialIconsFont.Activity,
                    AllSamplesList = new List<Sample>
                    {
                        Flows.First(x => x.FlowType == FlowType.Tasks),
                        Flows.First(x => x.FlowType == FlowType.Quiz),
                        Flows.First(x => x.FlowType == FlowType.News),
                        Flows.First(x => x.FlowType == FlowType.SmartHome),
                        Flows.First(x => x.FlowType == FlowType.Wizard),
                        Flows.First(x => x.FlowType == FlowType.Map),
                        Flows.First(x => x.FlowType == FlowType.Explorer),
                        Flows.First(x => x.FlowType == FlowType.Ecommerce),
                        Flows.First(x => x.FlowType == FlowType.Chat),
                        Flows.First(x => x.FlowType == FlowType.Movies),
                    }
                },

                new SampleCategory
                {
                    Id = 2,
                    Name = AppResources.StringCategoryOnboarding,
                    Description = AppResources.StringCategoryOnboardingDescription,
                    Icon = GrialIconsFont.Carousel,
                    Emoji = Emojis.mobile_phone_with_arrow,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitlePreferencesOnboarding,
                            DemoAppResources.PreferencesOnboardingPageDescription,
                            GrialIconsFont.Shield,
                            typeof(PreferencesOnboardingPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleVideoCarouselHighlights,
                            DemoAppResources.VideoCarouselHighlightsPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(VideoCarouselHighlightsPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.SampleTitleWalkthrough,
                            DemoAppResources.WalkthroughPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleWalkthroughGradient,
                            DemoAppResources.WalkthroughPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughGradientPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleWalkthroughIllustration,
                            DemoAppResources.WalkthroughPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughIllustrationPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleWalkthroughImage,
                            DemoAppResources.WalkthroughPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughImagePage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleWalkthroughMinimal,
                            DemoAppResources.WalkthroughPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughMinimalPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.SampleTitleWalkthroughFlat,
                            DemoAppResources.WalkthroughFlatPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughFlatPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.SampleTitleWalkthroughVariant,
                            DemoAppResources.WalkthroughPageDescription,
                            GrialIconsFont.Carousel,
                            typeof(WalkthroughVariantPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleEmptyState,
                            DemoAppResources.EmptyStatePageDescription,
                            GrialIconsFont.Hourglass,
                            typeof(EmptyStatePage)),
                        new Sample(
                            AppResources.PageTitleWelcome,
                            DemoAppResources.WelcomePageDescription,
                            GrialIconsFont.MapPin,
                            typeof(WelcomePage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleWelcomeVariant,
                            DemoAppResources.WelcomePageDescription,
                            GrialIconsFont.MapPin,
                            typeof(WelcomeVariantPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleStart,
                            DemoAppResources.StartPageDescription,
                            GrialIconsFont.MapPin,
                            typeof(StartPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleStartVariant,
                            DemoAppResources.StartVariantPageDescription,
                            GrialIconsFont.MapPin,
                            typeof(StartVariantPage))
                        {
                            IsModal = true
                        }
                    }
                },

                new SampleCategory
                {
                    Id = 3,
                    Name = AppResources.StringCategoryForms,
                    Description = AppResources.StringCategoryFormsDescription,
                    Icon = GrialIconsFont.Edit3,
                    Emoji = Emojis.card_file_box,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleStepsForm,
                            DemoAppResources.StepsFormPageDescription,
                            GrialIconsFont.Layers,
                            typeof(StepsFormPage)),
                        Flows.First(x => x.FlowType == FlowType.Explorer),
                        Flows.First(x => x.FlowType == FlowType.Wizard),
                        new Sample(
                            AppResources.PageTitleTabbedLogin,
                            DemoAppResources.TabbedLoginPageDescription,
                            GrialIconsFont.Tab,
                            typeof(TabbedLoginPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleFullBackgroundLogin,
                            DemoAppResources.FullBackgroundLoginPageDescription,
                            GrialIconsFont.Lock,
                            typeof(FullBackgroundLoginPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleFullBackgroundSignup,
                            DemoAppResources.FullBackgroundSignupPageDescription,
                            GrialIconsFont.Lock,
                            typeof(FullBackgroundSignupPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleOrganizationForm,
                            DemoAppResources.OrganizationFormPageDescription,
                            GrialIconsFont.FileText,
                            typeof(OrganizationFormPage)),
                        new Sample(
                            AppResources.PageTitleEmployeeForm,
                            DemoAppResources.EmployeeFormPageDescription,
                            GrialIconsFont.FileText,
                            typeof(EmployeeFormPage)),
                        new Sample(
                            AppResources.PageTitleSimpleSignUp,
                            DemoAppResources.SimpleSignUpPageDescription,
                            GrialIconsFont.CheckCircle,
                            typeof(SimpleSignUpPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleSimpleLogin,
                            DemoAppResources.SimpleLoginPageDescription,
                            GrialIconsFont.CheckCircle,
                            typeof(SimpleLoginPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleLogin,
                            DemoAppResources.LoginPageDescription,
                            GrialIconsFont.Lock,
                            typeof(LoginPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitleSignUp,
                            DemoAppResources.SignUpPageDescription,
                            GrialIconsFont.CheckCircle,
                            typeof(SignUpPage))
                        {
                            IsModal = true
                        },
                        new Sample(
                            AppResources.PageTitlePasswordRecovery,
                            DemoAppResources.PasswordRecoveryPageDescription,
                            GrialIconsFont.SettingsRestore,
                            typeof(PasswordRecoveryPage))
                        {
                            IsModal = true
                        },
                    }
                },

                new SampleCategory
                {
                    Id = 4,
                    Name = AppResources.StringCategoryNavigation,
                    Description = AppResources.StringCategoryNavigationDescription,
                    Icon = GrialIconsFont.Compass,
                    Emoji = Emojis.compass,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleSurveyList,
                            DemoAppResources.SurveyListPageDescription,
                            GrialIconsFont.Clipboard,
                            typeof(SurveyListPage)),
                        Flows.First(x => x.FlowType == FlowType.Map),
                        new Sample(
                            AppResources.PageTitleNavigationCardsDescriptionList,
                            DemoAppResources.NavigationCardsDescriptionListPageDescription,
                            GrialIconsFont.List,
                            typeof(NavigationCardsDescriptionListPage))
                        {
                            IsHidden = true
                        },
                        new Sample(
                            AppResources.PageTitleVideoListPreview,
                            DemoAppResources.VideoListPreviewPageDescription,
                            GrialIconsFont.Video,
                            typeof(VideoListPreviewPage)),
                        new Sample(
                            AppResources.PageTitleNavigationCardsList,
                            DemoAppResources.NavigationCardsListPageDescription,
                            GrialIconsFont.List,
                            typeof(NavigationCardsListPage)),
                        new Sample(
                            AppResources.PageTitleNavigationFlatList,
                            DemoAppResources.NavigationFlatListPageDescription,
                            GrialIconsFont.List,
                            typeof(NavigationFlatListPage)),
                        new Sample(
                            AppResources.PageTitleNavigationListWithImages,
                            DemoAppResources.NavigationListWithImagesPageDescription,
                            GrialIconsFont.List,
                            typeof(NavigationListWithImagesPage)),
                        new Sample(
                            AppResources.PageTitleNavigationListWithIcons,
                            DemoAppResources.NavigationListWithIconsPageDescription,
                            GrialIconsFont.List,
                            typeof(NavigationListWithIconsPage)),
                        new Sample(
                            AppResources.PageTitleTabControlCustomSample,
                            DemoAppResources.TabControlCustomSamplePageDescription,
                            GrialIconsFont.Tab,
                            typeof(TabControlCustomSamplePage)),
                        new Sample(
                            AppResources.PageTitleTabControlAndroidSample,
                            DemoAppResources.TabControlAndroidSamplePageDescription,
                            GrialIconsFont.Tab,
                            typeof(TabControlAndroidSamplePage)),
                        new Sample(
                            AppResources.PageTitleTabControliOSSample,
                            DemoAppResources.TabControliOSSamplePageDescription,
                            GrialIconsFont.Tab,
                            typeof(TabControliOSSamplePage)),
                        new Sample(
                            AppResources.PageTitleTabControlBottomPlacementSample,
                            DemoAppResources.TabControlBottomPlacementSamplePageDescription,
                            GrialIconsFont.Tab,
                            typeof(TabControlBottomPlacementSamplePage)),
                        new Sample(
                            AppResources.PageTitleTab,
                            DemoAppResources.TabPageDescription,
                            GrialIconsFont.Tab,
                            typeof(TabPage))
                    }
                },

                new SampleCategory
                {
                    Id = 5,
                    Name = AppResources.StringCategoryDashboards,
                    Description = AppResources.StringCategoryDashboardsDescription,
                    Icon = GrialIconsFont.Dashboard,
                    Emoji = Emojis.eyes,
                    AllSamplesList = new List<Sample>
                    {
                        Flows.First(x => x.FlowType == FlowType.SmartHome),
                        Flows.First(x => x.FlowType == FlowType.Movies),
                         new Sample(
                            AppResources.PageTitleDashboardSwipeableHeader,
                            DemoAppResources.DashboardSwipeableHeaderPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(DashboardSwipeableHeaderPage)),
                        new Sample(
                            AppResources.PageTitleDashboardCarousel,
                            DemoAppResources.DashboardCarouselPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(DashboardCarouselPage))
                        {
                            IsHidden = false
                        },
                        new Sample(
                            AppResources.PageTitleListWithColumns,
                            DemoAppResources.ListWithColumnsPageDescription,
                            GrialIconsFont.List,
                            typeof(ListWithColumnsPage)),
                        new Sample(
                            AppResources.PageTitleListWithColumnsVariant,
                            DemoAppResources.ListWithColumnsVariantPageDescription,
                            GrialIconsFont.List,
                            typeof(ListWithColumnsVariantPage)),
                        new Sample(
                            AppResources.PageTitleDashboardCards,
                            DemoAppResources.DashboardCardsPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(DashboardCardsPage)),
                        new Sample(
                            AppResources.PageTitleDashboardMultipleTiles,
                            DemoAppResources.DashboardMultipleTilesPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(DashboardMultipleTilesPage)),
                        new Sample(
                            AppResources.PageTitleIconsDashboard,
                            DemoAppResources.IconsDashboardPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(IconsDashboardPage)),
                        new Sample(
                            AppResources.PageTitleFlatDashboard,
                            DemoAppResources.FlatDashboardPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(FlatDashboardPage)),
                        new Sample(
                            AppResources.PageTitleImagesDashboard,
                            DemoAppResources.ImagesDashboardPageDescription,
                            GrialIconsFont.Dashboard,
                            typeof(ImagesDashboardPage))
                    }
                },

                new SampleCategory
                {
                    Id = 6,
                    Name = AppResources.StringCategoryArticles,
                    Description = AppResources.StringCategoryArticlesDescription,
                    Icon = GrialIconsFont.File,
                    Emoji = Emojis.page_facing_up,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleParallaxHeaderArticle,
                            DemoAppResources.FullHeaderArticlePagePageDescription,
                            GrialIconsFont.File,
                            typeof(ParallaxHeaderArticlePage)),
                        new Sample(
                            AppResources.PageTitleCardArticle,
                            DemoAppResources.CardArticlePageDescription,
                            GrialIconsFont.File,
                            typeof(CardArticlePage)),
                        new Sample(
                            AppResources.PageTitleCurvedHeaderArticle,
                            DemoAppResources.CurvedHeaderArticlePageDescription,
                            GrialIconsFont.File,
                            typeof(CurvedHeaderArticlePage)),
                        new Sample(
                            AppResources.PageTitleArticlesBrowser,
                            DemoAppResources.ArticlesBrowserPageDescription,
                            GrialIconsFont.File,
                            typeof(ArticlesBrowserPage)),
                        new Sample(
                            AppResources.PageTitleArticlesClassicView,
                            DemoAppResources.ArticlesClassicViewPageDescription,
                            GrialIconsFont.File,
                            typeof(ArticlesClassicViewPage)),
                        new Sample(
                            AppResources.PageTitleArticleDetail,
                            DemoAppResources.ArticleDetailPageDescription,
                            GrialIconsFont.File,
                            typeof(ArticleDetailPage)),
                        new Sample(
                            AppResources.PageTitleArticlesColumns,
                            DemoAppResources.ArticlesColumnPageDescription,
                            GrialIconsFont.FileText,
                            typeof(ArticlesColumnsPage)),
                        new Sample(
                            AppResources.PageTitleArticlesList,
                            DemoAppResources.ArticlesListPageDescription,
                            GrialIconsFont.FileText,
                            typeof(ArticlesListPage)),
                        new Sample(
                            AppResources.PageTitleArticlesListVariant,
                            DemoAppResources.ArticlesListPageDescription,
                            GrialIconsFont.FileText,
                            typeof(ArticlesListVariantPage)),
                        new Sample(
                            AppResources.PageTitleArticlesFeed,
                            DemoAppResources.ArticlesFeedPageDescription,
                            GrialIconsFont.FileText,
                            typeof(ArticlesFeedPage))
                    }
                },

                new SampleCategory
                {
                    Id = 7,
                    Name = AppResources.StringCategorySocial,
                    Description = AppResources.StringCategorySocialDescription,
                    Icon = GrialIconsFont.User,
                    Emoji = Emojis.busts_in_silhouette,
                    AllSamplesList = new List<Sample>
                    {
                        Flows.First(x => x.FlowType == FlowType.Quiz),
                        Flows.First(x => x.FlowType == FlowType.Chat),
                        new Sample(
                            AppResources.SampleUserProfile,
                            DemoAppResources.ProfilePageTimelinePageDescription,
                            GrialIconsFont.AccountCircle,
                            typeof(ProfilePage)),
                        new Sample(
                            AppResources.PageTitleSocial,
                            DemoAppResources.SocialPageDescription,
                            GrialIconsFont.Users,
                            typeof(SocialPage)),
                        new Sample(
                            AppResources.PageTitleSocialVariant,
                            DemoAppResources.SocialVariantPageDescription,
                            GrialIconsFont.Users,
                            typeof(SocialVariantPage)),
                        new Sample(
                            AppResources.PageTitleSocialCard,
                            DemoAppResources.SocialCardPageDescription,
                            GrialIconsFont.User,
                            typeof(SocialCardPage)),
                        new Sample(
                            AppResources.PageTitleTimeline,
                            DemoAppResources.TimelinePageDescription,
                            GrialIconsFont.Clock,
                            typeof(TimelinePage)),
                        new Sample(
                            AppResources.PageTitleContactSimpleDetail,
                            DemoAppResources.ContactSimpleDetailPageDescription,
                            GrialIconsFont.User,
                            typeof(ContactSimpleDetailPage))
                        {
                            IsModal = true
                        }
                    }
                },

                new SampleCategory
                {
                    Id = 8,
                    Name = AppResources.StringCategoryECommerce,
                    Description = AppResources.StringCategoryECommerceDescription,
                    Icon = GrialIconsFont.ShoppingCart,
                    Emoji = Emojis.shopping_cart,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleBookingReservation,
                            DemoAppResources.BookingReservationPageDescription,
                            GrialIconsFont.Calendar,
                            typeof(BookingReservationPage))
                            {
                                IsModal = true
                            },
                        Flows.First(x => x.FlowType == FlowType.Ecommerce),
                        new Sample(
                            AppResources.SampleProductFullscreen,
                            DemoAppResources.ProductImageFullScreenPageDescription,
                            GrialIconsFont.Gift,
                            typeof(ProductItemFullScreenPage)),
                        new Sample(
                            AppResources.PageTitleProductsCatalog,
                            DemoAppResources.ProductsCatalogPageDescription,
                            GrialIconsFont.Gift,
                            typeof(ProductsCatalogPage)),
                        new Sample(
                            AppResources.PageTitleProductOrder,
                            DemoAppResources.ProductOrderPageDescription,
                            GrialIconsFont.Gift,
                            typeof(ProductOrderPage)),
                        new Sample(
                            AppResources.PageTitleProductsGrid,
                            DemoAppResources.ProductsGridPageDescription,
                            GrialIconsFont.Module,
                            typeof(ProductsGridPage)),
                        new Sample(
                            AppResources.PageTitleProductsGridVariant,
                            DemoAppResources.ProductsGridVariantPageDescription,
                            GrialIconsFont.Module,
                            typeof(ProductsGridVariantPage)),
                        new Sample(
                            AppResources.SampleProductItemView,
                            DemoAppResources.ProductItemViewPageDescription,
                            GrialIconsFont.Gift,
                            typeof(ProductItemViewPage)),
                        new Sample(
                            AppResources.SampleProductCarousel,
                            DemoAppResources.ProductsCarouselPageDescription,
                            GrialIconsFont.Gift,
                            typeof(ProductsCarouselPage))
                    }
                },

                new SampleCategory
                {
                    Id = 9,
                    Name = AppResources.StringCategoryMessages,
                    Description = AppResources.StringCategoryMessagesDescription,
                    Icon = GrialIconsFont.Mail,
                    Emoji = Emojis.speech_balloon,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleCalendarSchedule,
                            DemoAppResources.CalendarSchedulePageDescription,
                            GrialIconsFont.Calendar,
                            typeof(CalendarSchedulePage)),
                        new Sample(
                            AppResources.PageTitleChatTimeline,
                            DemoAppResources.ChatTimelinePageDescription,
                            GrialIconsFont.Clock,
                            typeof(ChatTimelinePage)),
                        new Sample(
                            AppResources.PageTitleRecentChatList,
                            DemoAppResources.RecentChatListPageDescription,
                            GrialIconsFont.Clock,
                            typeof(RecentChatListPage)),
                        new Sample(
                            AppResources.PageTitleMessagesList,
                            DemoAppResources.MessagesListPageDescription,
                            GrialIconsFont.Mail,
                            typeof(MessagesListPage)),
                        new Sample(
                            AppResources.PageTitleChatMessagesList,
                            DemoAppResources.ChatMessagesListPageDescription,
                            GrialIconsFont.MessagesCircle,
                            typeof(ChatMessagesListPage)),
                        new Sample(
                            AppResources.PageTitleNotifications,
                            DemoAppResources.NotificationsPageDescription,
                            GrialIconsFont.Bell,
                            typeof(NotificationsPage)),
                    }
                },

                new SampleCategory
                {
                    Id = 10,
                    Name = AppResources.StringCategoryDataViz,
                    Description = AppResources.StringCategoryDataVizDescription,
                    Icon = GrialIconsFont.PieChart,
                    Emoji = Emojis.bar_chart,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleMediaRanking,
                            DemoAppResources.MediaRankingPageDescription,
                            GrialIconsFont.TrendingUp,
                            typeof(MediaRankingPage)),
                        new Sample(
                            AppResources.PageTitleSocialRanking,
                            DemoAppResources.SocialRankingPageDescription,
                            GrialIconsFont.TrendingUp,
                            typeof(SocialRankingPage)),
                        Flows.First(x => x.FlowType == FlowType.Tasks),
                        new Sample(
                            AppResources.PageTitleDocumentTimeline,
                            DemoAppResources.DocumentTimelinePageDescription,
                            GrialIconsFont.Clock,
                            typeof(DocumentTimelinePage)),
                        new Sample(
                            AppResources.PageTitleUsersAnalytics,
                            DemoAppResources.UsersAnalyticsPageDescription,
                            GrialIconsFont.BarChart,
                            typeof(UsersAnalyticsPage)),
                        new Sample(
                            AppResources.PageTitleTrafficAnalytics,
                            DemoAppResources.TrafficAnalyticsPageDescription,
                            GrialIconsFont.BarChart,
                            typeof(TrafficAnalyticsPage)),
                        new Sample(
                            AppResources.PageTitleWalletPie,
                            DemoAppResources.WalletPiePageDescription,
                            GrialIconsFont.PieChart,
                            typeof(WalletPiePage)),
                        new Sample(
                            AppResources.PageTitleWalletAlternative,
                            DemoAppResources.WalletAlternativePageDescription,
                            GrialIconsFont.BarChart,
                            typeof(WalletAlternativePage)),
                        new Sample(
                            AppResources.PageTitlePowerUsage,
                            DemoAppResources.PowerUsagePageDescription  ,
                            GrialIconsFont.BarChart2,
                            typeof(PowerUsagePage)),
                        new Sample(
                            AppResources.PageTitleWebsiteTrafficReport,
                            DemoAppResources.WebsiteTrafficReportPageDescription,
                            GrialIconsFont.BarChart2,
                            typeof(WebsiteTrafficReportPage)),
                       new Sample(
                           AppResources.PageTitleShippingDetail,
                           DemoAppResources.ShippingDetailPageDescription,
                           GrialIconsFont.Module,
                           typeof(ShippingDetailPage)),
                        new Sample(
                            AppResources.PageTitleTaskBrowser,
                            DemoAppResources.TaskBrowserPageDescription,
                            GrialIconsFont.BarChart,
                            typeof(TaskBrowserPage)),
                        new Sample(
                            AppResources.PageTitleTaskOverview,
                            DemoAppResources.TaskOverviewPageDescription,
                            GrialIconsFont.BarChart,
                            typeof(TaskOverviewPage))
                    }
                },

                new SampleCategory
                {
                    Id = 11,
                    Name = AppResources.StringCategoryTheme,
                    Description = AppResources.StringCategoryThemeDescription,
                    Icon = GrialIconsFont.ColorPalette,
                    Emoji = Emojis.artist_palette,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleThemeOverview,
                            DemoAppResources.ThemeOverviewPageDescription,
                            GrialIconsFont.ColorPalette,
                            typeof(ThemeOverviewPage)),
                        new Sample(
                            AppResources.PageTitlePopups,
                            DemoAppResources.PopupsPageDescription,
                            GrialIconsFont.MessageCircle,
                            typeof(PopupsPage)),
                        new Sample(
                            AppResources.PageTitleDeliveryWorkflow,
                            DemoAppResources.DeliveryWorkflowPageDescription,
                            GrialIconsFont.Package,
                            typeof(DeliveryWorkflowPage))
                            {
                                IsModal =true
                            },
                        new Sample(
                            AppResources.PageTitleCalendarShowcase,
                            DemoAppResources.CalendarShowcasePageDescription,
                            GrialIconsFont.Calendar,
                            typeof(CalendarShowcasePage)),
                        new Sample(
                            AppResources.PageTitleGenericAbout,
                            DemoAppResources.GenericAboutPageDescription,
                            GrialIconsFont.HelpCircle,
                            typeof(GenericAboutPage)),
                        new Sample(
                            AppResources.PageTitleRichAbout,
                            DemoAppResources.RichAboutPageDescription,
                            GrialIconsFont.HelpCircle,
                            typeof(RichAboutPage)),
                        new Sample(
                            AppResources.PageTitleCustomSettings,
                            DemoAppResources.CustomSettingsPageDescription,
                            GrialIconsFont.Settings,
                            typeof(CustomSettingsPage)),
                        new Sample(
                            AppResources.PageTitleFAQs,
                            DemoAppResources.FAQsPageDescription,
                            GrialIconsFont.AlertInfo,
                            typeof(FAQsPage)),
                        new Sample(
                            AppResources.PageTitleCustomActivityIndicator,
                            DemoAppResources.CustomActivityIndicatorPageDescription,
                            GrialIconsFont.Loader,
                            typeof(CustomActivityIndicatorPage)),
                        new Sample(
                            AppResources.PageTitleResponsiveHelpers,
                            DemoAppResources.ResponsiveHelpersPageDescription,
                            GrialIconsFont.Tablet,
                            typeof(ResponsiveHelpersPage))
                    }
                },
                new SampleCategory
                {
                    Id = 12,
                    Name = AppResources.StringCategorySettings,
                    Description = AppResources.StringCategorySettingsDescription,
                    Icon = GrialIconsFont.Settings,
                    Emoji = null,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitleSettingsMenu,
                            DemoAppResources.SettingsMenuPageDescription,
                            GrialIconsFont.Settings,
                            typeof(SettingsMenuPage)),
                        new Sample(
                            AppResources.PageTitleSettingsMenuVariant,
                            DemoAppResources.SettingsMenuVariantPageDescription,
                            GrialIconsFont.Settings,
                            typeof(SettingsMenuVariantPage))
                            {
                                IsModal = true
                            },
                        new Sample(
                            AppResources.PageTitleMySettings,
                            DemoAppResources.MySettingsPageDescription,
                            GrialIconsFont.Wrench,
                            typeof(MySettingsPage)),
                        new Sample(
                            AppResources.PageTitleAppPreferences,
                            DemoAppResources.AppPreferencesPageDescription,
                            GrialIconsFont.Wrench,
                            typeof(AppPreferencesPage)),
                        new Sample(
                            AppResources.PageTitleProfileSettings,
                            DemoAppResources.ProfileSettingsPageDescription,
                            GrialIconsFont.User,
                            typeof(ProfileSettingsPage))
                            {
                                IsModal = true
                            }
                    }
                },
                new SampleCategory
                {
                    Id = 13,
                    Name = AppResources.StringCategoryPaywall,
                    Description = AppResources.StringCategoryPaywallDescription,
                    Icon = GrialIconsFont.DollarSign,
                    Emoji = Emojis.money_bag,
                    AllSamplesList = new List<Sample>
                    {
                        new Sample(
                            AppResources.PageTitlePricingPlanA,
                            DemoAppResources.PricingPlanAPageDescription,
                            GrialIconsFont.DollarSign,
                            typeof(PricingPlanAPage)),
                        new Sample(
                            AppResources.PageTitlePricingPlanB,
                            DemoAppResources.PricingPlanBPageDescription,
                            GrialIconsFont.DollarSign,
                            typeof(PricingPlanBPage)),
                        new Sample(
                            AppResources.PageTitlePricingPlanC,
                            DemoAppResources.PricingPlanCPageDescription,
                            GrialIconsFont.DollarSign,
                            typeof(PricingPlanCPage)),
                        new Sample(
                            AppResources.PageTitlePricingPlanD,
                            DemoAppResources.PricingPlanDPageDescription,
                            GrialIconsFont.DollarSign,
                            typeof(PricingPlanDPage))
                    }
                },
            };
        }

    }


    public class SampleCategory
    {
        public string Image { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Emoji { get; set; }
        public string Description { get; set; }
        public List<Sample> AllSamplesList { get; set; }
        public IEnumerable<Sample> SamplesList => AllSamplesList.Where(x => !x.IsHidden);
        public int ScreenCount => SamplesList.Sum(x => x.ScreenCount);
        public string ScreenCountDescription => string.Format(DemoAppResources.ScreenCount, ScreenCount);
    }

    public class ThemeOverviewCategory : SampleCategory
    {
    }


    public class Sample
    {
        public Sample(string name, string description, string icon, Type pageType)
        {
            Name = name;
            Description = description;
            Icon = icon;
            PageType = pageType;
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public Type PageType { get; set; }
        public bool IsModal { get; set; }
        public bool IsHidden { get; set; }
        public bool IsFlow { get; set; }
        public virtual int ScreenCount => 1;
        public FlowSample ParentFlow { get; set; }

        public virtual Task Open(INavigation navigation)
        {
            var page = Activator.CreateInstance(PageType) as Page;

            if (ParentFlow != null && ParentFlow.PageType != null)
            {
                var navPage = Activator.CreateInstance(ParentFlow.PageType, page) as NavigationPage;
                return navigation.PushModalAsync(navPage);
            }

            if (IsModal)
            {
                return navigation.PushModalAsync(new NavigationPage(page));
            }

            return navigation.PushAsync(page);
        }
    }


    public class FlowSample : Sample
    {
        private List<Sample> _individualPages;

        public FlowSample(string name, string description, string icon, Color lightColor, Color darkColor, Type pageType, FlowType flowType)
            : base(name, description, icon, pageType)
        {
            FlowType = flowType;
            IsFlow = true;
            LightColor = lightColor;
            DarkColor = darkColor;
        }

        public bool ShowInMainCarousel { get; set; }
        public Color LightColor { get; set; }
        public Color DarkColor { get; set; }
        public FlowType FlowType { get; set; }
        public override int ScreenCount => IndividualPages.Count;

        public List<Sample> IndividualPages
        {
            get => _individualPages;
            set
            {
                _individualPages = value;
                if (value != null)
                {
                    value.ForEach(sample => sample.ParentFlow = this);
                }
            }
        }
    }
}
