   M S B A M L   `   `   `  ����   Proyecto_Final_23AM'    !Proyecto_Final_23AM.Vista.Sistema   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Sistema��$	��450��$	��800��.��� ���#F2F2F2 � RowDefinitions �� $
��215* ��� $
��219* �.+��� $��Bienvenido al sistema��$��Center=�$	��Top=�
��� � �
������ 
�������$��10q�$��36(�$	��800��$��Center=�$��Segoe UI Black)�� $��50,104,51,22q�
�������$��2�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $	��108 ��� .+��� $��0��$��Id��$��Center=�
�������$��Center=�$
��Bold"�
��� � �$��26��$��0,0,1,0q��� -    ��Name$ 	TxtPkUser��$��0��${�False��$��2��$��	107,0,0,0q��� $��1��$��0��$��Nombre��$��Center=�
�������$��Center=�$
��Bold"�
��� � �$��0,0,1,0q�$��26���� -   $ 	txtNombre��$��1��$��
107,0,0,25q�$��2��$��2���� $��2��$��0��$��Usuario��$��Center=�
�������$��Center=�$��Center=�$
��Bold"�
��� � �$��0,0,1,0q�$��26���� -   $ txtUserName��$��2��$��	107,0,0,0q�$��2���� $��3��$��0��$��Password��$��Center=�
�������$��Center=�$
��Bold"�
��� � �$��0,0,1,0q�$��26���� -   $ txtPassword��$��3��$��	107,0,0,0q�$��2���� $��4��$��0��$��Roles��$��Center=�
�������$��Center=�$
��Bold"�
��� � �$��26��$��0,0,1,0q��� -    ��Name$ 	SelectRol��$��4��$��2��$��	107,0,0,0q��� -    ��Name$ BtnAdd��$��5��$��Agregar��$��Center=�$��82��$��	0,10,0,10q����	#FF43C12A
�������$
��Bold"��� -   $ BtnSave��$��5��$��1��$��Guardar��$
��Left=�$��82��$��482,10,0,10q����	#FF43C12A
�������${�False��$
��Bold"�&   System.Windows.Controls.DataGrid  -     Name$ 	UserTable��$��6��$��0��$��2��   AutoGenerateColumns$ False��   CanUserAddRows$ False��	   
IsReadOnly$
	 True��$��	1,10,0,10q�
�������
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	PkUsuario+  $ Nombre�� �� *Nombre+  $ Usuario�� �� *
Username+  $ Password�� �� *
Password+  $	 Rol�� �� *Roles.Nombre+4  .System.Windows.Controls.DataGridTemplateColumn  $ Editar��   CellTemplate �� .R��� -	   $��Editar�����#96E486
�������  $ Eliminar�� �� .R��� -
   $��Eliminar�����#E84848
��������� $
��Left=�$��55��$��	608,5,0,0q�$	��Top=�$��59��$��/Images/desconocido.png��