# apbd-cw1-git-s33101

merge nie był fast-forward, ponieważ zostały dokonane zmiany na gałęzi main, przy wykonaniu tego merge potrzebna byla wiadpmosc dotycznaca celu mergowania oby galezi


1. Git wykona fast-forward gdy na gałęzi main nie zostały wprowadzone zmiany, będą one wprowadzane tylko na gałęzi bocznej. Merge commit powstanie gdy zmiany zostaną wprowadzone zarówno na gałęzi main, jaki i gałęzi pobocznej.

2.Merge łączy gałęzie i zachowuje commity w ich oryginale wersji,. W przypadku rebase commity przenoszone są na szczyt gałęzi main (głównej) oraz commity nie zachowują swoich oryginalnych id.

3. Konflikt został rozwiązany poprzez zastąpienie zmiany wykonanych na gałęzi pobocznej (feature-conflict) na zmiany dokonane na gałęzi main. Problem został rozwiązany w programie Rider. 