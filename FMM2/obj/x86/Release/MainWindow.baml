   M S B A M L   `   `   `  ���� >  :FMM, Version=2.0.1.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FMM2FMM2      FMM2.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:FMM2     -     � Title$*  $Foundation Mod Manager v2.02 Midship��$	��670��$	��800�� � DataContext ��  �� RelativeSource �� *Self+����  �� Color# � �� � 	Resources    FMM2.SwitchConverter   
convSwitch  infobarGradient �� EndPoint �� 
StartPoint � Color � Offset��%�   &	        &	        �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#CC000000��$ 1Q�� $ 	#00555555��$	 0.3Q�� $ 	#22555555��$	 0.5Q�� $ 	#77555555��$ 0.748Q�.��� .+�� -   	 �Name$	 everythingGrid��.+��� -   
 ��Name$
 modsTabs��$��0,18,0,0q�.@��� -    ��Name$ 	myModsTab��$��My Mods��.��� -   $	 myModsOuterGrid��$��0q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� .+�� -   $	 myModsAlert�����	#FFFFF2C7$��0q�$��0��$��24��.+��� -    ��Name$ myModsAlertText��$
��Wrap=�$N��HAs of FMM2, mods highest on the list will be installed first by default.��$
��Left=� �� Padding$ 5,0,0,0q�$��0q�$��Center=��� -    ��Name$ myModsAlertHide��$��OK��$��0q�$��Right=�$��30��$��0q�� -	   $	 
myModsMenu��$��0q�$��24��$��1��#��� ��.+��� -
   $ myModsRefreshButton��$��Refresh��$��62��$��2,2,0,2q�$
��Left=��� -    ��Name$ myModsStatusNumber��$��0 mods available��$��69,0,0,0q�$
��Left=�$	��259���� -    ��Name$ myModsSearchBox�� �� TextWrapping$
 Wrap=�$��Right=�$	��187��$��0,2,0,2q�� -   $	 
myModsGrid�� � UseLayoutRounding .  $��0q�$��2�� � ColumnDefinitions �� �� $��5 ��� $	��250 �.+��� -    ��Name$ 
myModsList��$��0q� �� SelectionMode$ Single=� J� 	AllowDrop . $
��Auto=�$
��Auto=���Z�    ItemContextMenu��%�   &	       �� .@�m� -   $"��Mark/Unmark for Installation��m� -   $"��Open Folder in File Explorer��m� -   $��
Delete Mod������  �� 
TargetType" ��.���  �� Property �@�ContextMenu �� Value# [ ��  �@�ToolTip ��  �� Path$ Description� �� View �� .P���  �� Width$ 30�� �� CellTemplate �� .R���  ��Name$ myModsCB��  d� 	IsChecked  �� $ 	IsChecked�! �� Mode$! TwoWay=�" �� UpdateSourceTrigger$" PropertyChanged=��� -   gv1Name��$
��Name��$	 150��# �� DisplayMemberBinding# �� *Name+�� -   	gv1Author��$��Author��$ 90��# �� *Author+�� -   
gv1Version��$��Version��$ 90��# �� *	Version+�� -   gv1Description��$��Description��$	 200��# �� *Description+�� -   gv1Warnings��$��Warnings��$	 170��# �� *
Warnings+�� $��1��$��5��$��Stretch=�
�������� -   $	 infobar��$��2��$��0,0,0,0q� �� �� $��40 �.+��� -   $ ��Name$$ infobarScroll��$
��Auto=�.���� -   % ��Name$% infobarPanel��& �� Orientation$& Vertical=�$��0,0,0,0q�$	��Top=�.+�(� $��0,0,0,0q�$��Center=�$��Center=�.���� -   ' ��Name$' 
infobarCon��.��� -   $	 infobarViewGrid��$
��Left=�$��72��$	��128��.+��� -   ( ��Name$( infobarImage��) J� OpacityMask
) �   �$��0q�$��Center=�$��UniformToFill=����� *SelectedItem.Image+* �� ElementName$* 
myModsList���� -   + ��Name$+ infobarRect������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#CC000000��$ 1Q�� $ 	#00555555��$	 0.3Q�� $ 	#22555555��$	 0.5Q�� $ 	#77555555��$ 0.748Q��� -   $% infobarHeader��$��Disabled=�$��Bottom=�$��3,0,28,3q�.+��� -   $ infobarName��$	��Top=�$
��Bold"�$ 0q�$��7(�$��0q�
�������$
��Wrap=�
��� $
��Bold"���� *SelectedItem.Name+$* 
myModsList�� �� $��Normal"���� *SelectedItem.Version+$* 
myModsList���� -    $ infobarAuthor��$	��Top=�$ 0q�$��7(�
�������$
��Wrap=����� *SelectedItem.Author+$* 
myModsList���� -!   $ infobarCredits��$	��Top=�$ 0q�$��5(�
�������$
��Wrap=����� *SelectedItem.Credits+$* 
myModsList���� -"   $( infobarIcon��$��24��$��24��
) �   �$��0,0,2,2q�$��UniformToFill=�$��Right=�$��Bottom=����� *SelectedItem.Icon+$* 
myModsList���� -#   $% 
infobarOps��$& 
Horizontal=�$��5,5,5,0q�.+��� -$   $ 	infobarUp��$��26��$��20��$��0,0,2,0q�.���� $��0q�.+��� $��	fmmup.png��$��16��$��16���� -%   $ 	infobarDn��$��26��$��20��$��0,0,2,0q�.���� $��0q�.+��� $��fmmdown.png��$��16��$��16���� -&   $ infobarDelete��$��26��$��20��$��0,0,2,0q�.���� $��0q�.+��� $��fmmclose.png��$��16��$��16���� -'   $ infobarRevisionDate��$
��Wrap=�$	��Top=�$ 0q�$��12(�$��5,5,5,0q����� *SelectedItem.RevisionDate+$* 
myModsList��, �� StringFormat$, Last revision: {0}���� -(   $ infobarEDVersion��$
��Wrap=�$	��Top=�$ 0,0,0,0q�$��12(�$��5,5,5,0q����� *SelectedItem.EDVersion+$* 
myModsList��$, ElDewrito version: {0}���� -)   $ infobarDescription��$
��Wrap=�$ 0q�$��5,5,5,0q���`� - `� 	Converter#- [  .1��� $* 
myModsList��$ SelectedItem.LongDesc��� $* 
myModsList��$ SelectedItem.Desc��� -*   $ infobarWarnings��$
��Wrap=�$ 0q����	#FFAA641E$��5,5,5,0q���`� #- [  .1��� $* 
myModsList��$ SelectedItem.LongWarnings��� $* 
myModsList��$ SelectedItem.Warnings��� -+   $ infobarApply��$��Apply Checked Mods��$��10q�$��1���� -,   $ downloadableModsTab��$��Downloadable Mods��.��� --   $	 downloadableModsOuterGrid��$��0q� �� $
��Auto ��� $
��Auto ��� .+�� -.   $	 downloadableModsAlert�����	#FFFFCCC7$��0��$��0q�$��24��.+��� -/   $ downloadableModsAlertText��$
��Wrap=�$K��EThe GitHub mods repository is currently down. Please try again later.��$
��Left=�$ 5,0,0,0q�$��0q�$��Center=��� -0   $ downloadableModsAlertHide��$��OK��$��0q�$��Right=�$��30��$��0q�� -1   $	 downloadableModsMenu��$��0q�$��24��$��1��#��� ��.+��� -2   $ dlModsRefreshButton��$��Refresh��$��62��$��2,2,0,2q�$
��Left=��� -3   $ dlModsStatusNumber��$��0 mods available��$��69,0,0,0q�$
��Left=�$	��259���� -4   $ dlModsSearchBox��$
 Wrap=�$��Right=�$	��187��$��0,2,0,2q�� -5   $	 downloadableModsGrid�� .  $��0q�$��2�� �� �� $��5 ��� $	��250 �.+��� -6   $ downloadableModsList��$��0q�$ Single=� . $
��Auto=�$
��Auto=���Z� ���� " ��.���  �@�ToolTip �� $ Description� �� .P��� $ 30�� �� .R��� $ downloadableModsCB��  �� $ 	IsChecked�$! TwoWay=�$" PropertyChanged=��� -7   gv2Name��$
��Name��$	 150��# �� *Name+�� -8   	gv2Author��$��Author��$ 90��# �� *Author+�� -9   
gv2Version��$��Version��$ 90��# �� *	Version+�� -:   gv2Description��$��Description��$	 200��# �� *Description+�� -;   gv2Warnings��$��Warnings��$	 170��# �� *
Warnings+�� $��1��$��5��$��Stretch=�
�������� -<   $	 	infobarDL��$��2��$��0,0,0,0q� �� �� $��40 �.+��� -=   $$ infobarDLScroll��$
��Auto=�.���� ->   $% infobarDLPanel��$& Vertical=�$��0,0,0,0q�$	��Top=�.+�(� $��0,0,0,0q�$��Center=�$��Center=�.���� -?   $' infobarDLCon��.��� -@   $	 infobarDLViewGrid��$
��Left=�$��72��$	��128��.+��� -A   $( infobarDLImage��
) �   �$��0q�$��Center=�$��UniformToFill=����� *SelectedItem.Image+$* downloadableModsList���� -B   $+ infobarDLRect������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#CC000000��$ 1Q�� $ 	#00555555��$	 0.3Q�� $ 	#22555555��$	 0.5Q�� $ 	#77555555��$ 0.748Q��� -C   $% infobarDLHeader��$��Disabled=�$��Bottom=�$��3,0,28,3q�.+��� -D   $ infobarDLName��$	��Top=�$
��Bold"�$ 0q�$��7(�
�������$
��Wrap=�
��� $
��Bold"���� *SelectedItem.Name+$* downloadableModsList�� �� $��Normal"���� *SelectedItem.Version+$* downloadableModsList���� -E   $ infobarDLAuthor��$	��Top=�$ 0q�$��7(�
�������$
��Wrap=����� *SelectedItem.Author+$* downloadableModsList���� -F   $ infobarDLCredits��$	��Top=�$ 0q�$��5(�
�������$
��Wrap=����� *SelectedItem.Credits+$* downloadableModsList���� -G   $( infobarDLIcon��$��24��$��24��
) �   �$��0,0,2,2q�$��UniformToFill=�$��Right=�$��Bottom=����� *SelectedItem.Icon+$* downloadableModsList���� -H   $ infobarDLRevisionDate��$
��Wrap=�$	��Top=�$ 0q�$��12(�$��5,5,5,0q����� *SelectedItem.RevisionDate+$* downloadableModsList��$, Last revision: {0}���� -I   $ infobarDLEDVersion��$
��Wrap=�$	��Top=�$ 0,0,0,0q�$��12(�$��5,5,5,0q����� *SelectedItem.EDVersion+$* downloadableModsList��$, ElDewrito version: {0}���� -J   $ infobarDLDescription��$
��Wrap=�$ 0q�$��5,5,5,0q���`� #- [  .1��� $* downloadableModsList��$ SelectedItem.LongDesc��� $* downloadableModsList��$ SelectedItem.Desc��� -K   $ infobarDLWarnings��$
��Wrap=�$ 0q����	#FFAA641E$��5,5,5,0q���`� #- [  .1��� $* downloadableModsList��$ SelectedItem.LongWarnings��� $* downloadableModsList��$ SelectedItem.Warnings��� -L   $ infobarDLDownload��$��Download Checked Mods��$��10q�$��1��o� -M   . o�Name$
. menu��/ o� 
IsMainMenu/ . $	��Top=�.@�m� -N   0 m�Name$
0 file��$��_File��.@�m� -O   $0 	fileAbout��$��_About���� m� -P   $0 fileExit��$��_Exit��m� -Q   $0 options��$��_Options��.@�m� -R   $0 optionsOrder��$��_List Order��.@�m� -S   $0 optionsOrderList��$��_Install Order��1 m� IsCheckable1 . 2 m� 	IsChecked2 . m� -T   $0 optionsOrderPriority��$��_Priority Order��1 . 2 .  �� m� -U   $0 optionsOffline��$��_Offline Mode��1 . m� -V   $0 optionsDeveloper��$��_Developer Mode��1 . �� -W   3 ��Name$3 optionsDeveloperSeparator��m� -X   $0 optionsDeveloperOptions��$��_Developer Options��.@�m� -Y   $0 optionsDeveloperBackup��$%��_Create Backup On First Install��1 . 2 . m� -Z   $0 optionsDeveloperRestore��$��_Restore Files On Install��1 . 2 . m� -[   $0 optionsDeveloperTagTool��$��_Show TagTool Window��1 . 2 .  � -\   $	 installLogGrid�����	#B2F0F0F0$y�	Collapsed=�$��0q�.+��� -]   $$ installLogScroll��$��0,0,0,30q�.���� -^   $ installLogBox��$
��Wrap=�$8��2Consolas, Courier New, Lucida Console, Ubuntu Mono)�
���   �$ 5q��� $��30��$��Bottom=�$	��5,0q����	#B2F0F0F0.@��� $��Right=�.���� -_   $ closeLogButton��$��	Close Log��$	��150��