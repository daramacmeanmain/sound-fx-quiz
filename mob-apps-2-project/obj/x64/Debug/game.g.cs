﻿#pragma checksum "C:\Users\Dara\Documents\Visual Studio 2015\Projects\mob-apps-2-project\mob-apps-2-project\mob-apps-2-project\game.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "476CBBEFC36A9206A8B7E651E70AB2A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mob_apps_2_project
{
    partial class game : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.h_ban = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 2:
                {
                    this.h_camo = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3:
                {
                    this.h_elite = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 4:
                {
                    this.h_over = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 5:
                {
                    this.h_rifle = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 6:
                {
                    this.h_warthog = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 7:
                {
                    this.hl_cb = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 8:
                {
                    this.hl_energy = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 9:
                {
                    this.hl_phys = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 10:
                {
                    this.mgs_call = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 11:
                {
                    this.mgs_found = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 12:
                {
                    this.mgs_go = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 13:
                {
                    this.st_alien = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 14:
                {
                    this.st_bridge = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 15:
                {
                    this.st_chirp = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 16:
                {
                    this.st_transbeep = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 17:
                {
                    this.st_transporter = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 18:
                {
                    this.sw_alarm = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 19:
                {
                    this.sw_blaster = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 20:
                {
                    this.sw_chewy = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 21:
                {
                    this.sw_lightsaber = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 22:
                {
                    this.sw_r2d2 = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 23:
                {
                    this.sw_wilhelm = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 24:
                {
                    this.Audio = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Audio).Tapped += this.play_Tapped;
                    #line default
                }
                break;
            case 25:
                {
                    this.halflife = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.halflife).Tapped += this.hl_Tapped;
                    #line default
                }
                break;
            case 26:
                {
                    this.halo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.halo).Tapped += this.h_Tapped;
                    #line default
                }
                break;
            case 27:
                {
                    this.startrek = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.startrek).Tapped += this.st_Tapped;
                    #line default
                }
                break;
            case 28:
                {
                    this.starwars = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.starwars).Tapped += this.sw_Tapped;
                    #line default
                }
                break;
            case 29:
                {
                    this.metalgear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.metalgear).Tapped += this.mgs_Tapped;
                    #line default
                }
                break;
            case 30:
                {
                    this.gameover = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.gameover).Tapped += this.gameover_Tapped;
                    #line default
                }
                break;
            case 31:
                {
                    this.win = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\game.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.win).Tapped += this.gameover_Tapped;
                    #line default
                }
                break;
            case 32:
                {
                    this.Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 33:
                {
                    this.Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 34:
                {
                    this.Test = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

