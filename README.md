# apbd-cw1-git-s33758

Zad.5
Merge nie był fast-forward, ponieważ przed wykonaniem merga w mainie dodaliśmy nową rzecz, przez co linie rozeszły się w czasie

Pytania
1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
   Fast-forward jest, wtedy gdy dodajemy jakąś metode w innej gałęzi, i robimy commit tylko w niej po czym używamy od razu merga, natomiast gdy dodamy jeszcze coś do maina i zrobimy jeszcze w nim commita to wtedy mamy merge commit
2. Czym w praktyce różni się merge od rebase?\
   Merge po prostu łączy 2 gałęzie czesto tworząc połączenie takie drzewo, a rebase na nowo tworzy wszytsko przez co mamy mniej więcej tak jak fast-forward
3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
   Zmieniłem w obu nazwę zmiennej, więc dodałem z obu stron rozwiązania i usunąłem jedynie obliczenie c, ponieważ 2 razy tworzyłem tego samegi inta
