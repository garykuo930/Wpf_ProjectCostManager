   M S B A M L   `   `   `  ����Q  MWpf_ProjectCostManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Wpf_ProjectCostManagerWpf_ProjectCostManager  5   	   H DPMEntityModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:PMEntityModel;assembly=PMEntityModelPMEntityModel 5   	   '    !Wpf_ProjectCostManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Wpf_ProjectCostManager     5   	   LPMEntityModel2clr-namespace:PMEntityModel;assembly=PMEntityModel     5   	   -   5        ���	#FF404040  � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5         taskResourceViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   �� .@�5      �� $��專案列表��6   .��5      � ���	#FF404040.+�5      � -   5         �Name$ 	wrapPanel��5       5      5      �� 5      $��費用管理��6   .��5      � ���	#FF404040 � DataContext# [  6.    � RowDefinitions 5      �� 5      $	��39* �6(   �� 5      $	��32* �6(   �� 5      $
��312* �6(   .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ btn_add��5   !   $��新增��62   $	��100��6?   $��3q�6K   {�. 
�������
����� �6�   �� 5      -   5        $ 
btn_search��5   !   $��查詢��65   $	��100��6B   $��3q�6N   {�. 
�������
����� �6�   �� 5      -   5        $ 
btn_modify��5   !   $��修改��65   $	��100��6B   $��3q�6N   {�. 
�������
����� �6�   �� 5       -   5        $ 
btn_delete��5    !   $��刪除��65   $	��100��6B   $��3q�6N   {�. 
�������
����� �6�   �� 5!      -   5        $ btn_save��5!   !   $��存檔��63   $	��100��6@   $��3q�6L   {�. 
�������
����� �6�   �� 5"      -   5        $ btn_reverse��5"   !   $��取消變更��66   $	��100��6E   $��3q�6Q   {�. 
�������
����� �6�   5#      �� 5$      $��1��6!   $ 
Horizontal=�6.   .+�5%      �� $��5��6$   �� 5&      
�������$��專案代號：��67   $��Center=�6D   �� 5'      -	   5         ��Name$ tb_ProjectID��5'   "   $��23��68    �� TextWrapping$
 Wrap=�6D   $�� ��6X   $	��120��6`   6l   �� 5(      $��50��6$   �� 5)      
�������$��專案名稱：��67   $��Center=�6D   �� 5*      -
   5        $ tb_ProjectName��5*   "   $��23��6:   $
 Wrap=�6F   $�� ��6Z   $	��120��6b   �� 5+      $��10��6$   �� 5,      -   5        $	��...��5,   !   $��22��6/   
����������	#FF4040406d   5-      &   System.Windows.Controls.DataGrid  5.      -   5        	  Name$	 taskResourceDataGrid��5.      
   AutoGenerateColumns
 .     EnableRowVirtualization . $��2��6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ���	#FF404040   CanUserAddRows .  ��6x   ��    Columns 5/      4  .System.Windows.Controls.DataGridTemplateColumn  50      -   5        
dateColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 日期��50   I      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6U      CellTemplate 51   "   �� 52   &   .R�53   *   (  "System.Windows.Controls.DatePicker     SelectedDate 65   �� *Date+ �� Mode$ OneWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 54   '   56      0  *System.Windows.Controls.DataGridTextColumn  57      -   5        resourceIDColumn��$ 費用名稱��57   l   $	 100 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *ResourceName+6z   4  .System.Windows.Controls.DataGridComboBoxColumn  58      -   5        resourceNameColumn��$ 費用類別��58   ~   $	 150 6�      SelectedItemBinding 6Q   �� *CategoryName+6�     59      -   5        quantityColumn��$ 數量��59   f   $ 50 6r    6I   �� *
Quantity+6r     5:      -   5        
unitColumn��$ 單位��5:   ^   $ 50 6j    6E   �� *Unit+6j     5;      -   5        unitPriceColumn��$ 單價��5;   y   $	 100 6�    6J   �� *	UnitPrice+ �� StringFormat$ C2��6�     5<      -   5        subtotalColumn��$ 小計��5<   w   $	 100 6�    6I   �� *
SubTotal+$ C2��6�     5=      -   5        descriptionColumn��$ 備註��5=   l   $	 500 6x    6L   �� *Description+6x   5?      5@      5A      5B      5C      5D      