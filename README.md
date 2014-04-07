Primula.W8
==========

Windows 8 application that is a cash dest made for tablets


Libraries / Resources that help us to create this application :
- http://msdn.microsoft.com/en-US/windows/apps/hh779072

MVVM & Caliburn.Micro Framework resources :
- https://caliburnmicro.codeplex.com/wikipage?title=Working%20with%20WinRT&referringTitle=Documentation
- http://www.terrymarshall.com.au/Blog/tabid/162/EntryId/157/WinRT-and-Caliburn-Micro-Part-1-Introduction.aspx (Whole series from Part 1 to Part )

Video (in Polish):
- http://channel9.msdn.com/Series/Tworzenie-aplikacji-w-stylu-Modern-UI-dla-programist-w/MVVM-Tworzenie-aplikacji-dla-systemu-Windows-8-dla-programistw
- http://channel9.msdn.com/Series/Tworzenie-aplikacji-w-stylu-Modern-UI-dla-programist-w/MVVM-Command-cz2-Tworzenie-aplikacji-dla-systemu-Windows-8-dla-programisty

Common Views
- Splashscreen 
- LoginView (need account if you wanna use our application)

Seller Views
- Dashboard (This view/page is home of each user, here is basic information about seller, button that allow us to start with new order)
- OrderCandidateView (This view is first step to make a order, at this stage basket is mutable)
- FinalizeOrderView - at this step, all items from OrderCandidate are immutable! also at this stage we decide about payment method)
- OrderPaymentView - last stage here is the final confirmation maked order, after this application will navigate us to Dashboard


Design info :

Fonts:
- TextBoxes : 28
- Buttons : 20
- Title (view) : 54

Colors:
- #C4f492
- #8CC63F
