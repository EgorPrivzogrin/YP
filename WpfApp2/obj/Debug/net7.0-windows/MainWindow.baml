   M S B A M L   `   `   `  ????B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   $	??450??5      $	??800??6'     ? WindowStartupLocation$  CenterScreen=?63    ? Title$% Нанятый персонал??6X   .??5      ? 
??????? ? RowDefinitions 5	   
   ?? 5
      ?? 5      $??50 ?6   .+?5   
   ?? -   5         ??Name$ employmentsList??5      ???	#FF0D1117
?????????6+   ?? ??5      ?? 5      .R?5      ?? .+?5      ?? ?? 5      $??16(?6;   ?6"   ?? *	Surname+6;    ?? 5      $??16(?68   ?6"   ?? *Name+68    ?? 5      $??16(?6>   ?6"   ?? *
Patronymic+6>   5      5      5      5      ?? 5   
   $??1??6    ?? Orientation$ 
Horizontal=?6"   $??Center=?6;   .+?5      ?? -   5        $??Нанять??5      $??10q?6&   ???	#FF0D1117
???????6[   ?? 5      -   5        $??Уволить??5      $??10q?6'   ???	#FF0D1117
???????6`   ?? 5      -   5        $??Изменить??5      $??10q?6(   ???	#FF0D1117
???????6_   ?? 5      -   5        $??Экспорт в Exсel??5      $??10q?6/   ???	#FF0D1117
???????6p   5      5       5!      