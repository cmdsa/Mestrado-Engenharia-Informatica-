#pragma checksum "/home/bruno/SNMPSERVER/Pages/Testpage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0de0a2e18a67814861eff453c416117128103b9"
// <auto-generated/>
#pragma warning disable 1591
namespace SNMPSERVER.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/bruno/SNMPSERVER/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/bruno/SNMPSERVER/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/bruno/SNMPSERVER/_Imports.razor"
using SNMPSERVER;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/bruno/SNMPSERVER/_Imports.razor"
using SNMPSERVER.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/bruno/SNMPSERVER/_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
using Blazorise.Charts.Streaming;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Testpage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Processos SNMP</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Processos que estão a correr e memória utilizada</p>\r\n \r\n");
            __builder.OpenComponent<Blazorise.Row>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                      ipPortForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                  start

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                    __builder3.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                 ipPortForm.IpAdress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ipPortForm.IpAdress = __value, ipPortForm.IpAdress))));
                    __builder3.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ipPortForm.IpAdress));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __Blazor.SNMPSERVER.Pages.Testpage.TypeInference.CreateInputNumber_0(__builder3, 17, 18, 
#nullable restore
#line 15 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                   ipPortForm.portNumb

#line default
#line hidden
#nullable disable
                    , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ipPortForm.portNumb = __value, ipPortForm.portNumb)), 20, () => ipPortForm.portNumb);
                    __builder3.AddMarkupContent(21, "\r\n        \r\n        ");
                    __builder3.OpenComponent<Blazorise.Button>(22);
                    __builder3.AddAttribute(23, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 17 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                       Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ButtonType>(
#nullable restore
#line 17 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "Começar");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 23 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
 if (indexprocess == null)
{

     
}
else{
   
    


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.Row>(27);
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(29);
                __builder2.AddAttribute(30, "style", "height: 110vh;");
                __builder2.AddAttribute(31, "class", "overflow-auto");
                __builder2.AddAttribute(32, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 34 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                                 ColumnSize.IsFull.OnDesktop.IsHalf.OnWidescreen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Card>(34);
                    __builder3.AddAttribute(35, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 35 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                   Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.CardBody>(37);
                        __builder4.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Table>(39);
                            __builder5.AddAttribute(40, "Striped", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                            true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.TableHeader>(42);
                                __builder6.AddAttribute(43, "TableHeader", true);
                                __builder6.AddAttribute(44, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 39 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                    ThemeContrast.Dark

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Blazorise.TableRow>(46);
                                    __builder7.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<Blazorise.TableHeaderCell>(48);
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(49, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableHeaderCell>(50);
                                        __builder8.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(52, "id Processo");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(53, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableHeaderCell>(54);
                                        __builder8.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(56, "Nome");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(57, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableHeaderCell>(58);
                                        __builder8.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(60, "Memoria usada");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(61, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableHeaderCell>(62);
                                        __builder8.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(64, "CPU usado");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(65, "\r\n            ");
                                __builder6.OpenComponent<Blazorise.TableBody>(66);
                                __builder6.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
#nullable restore
#line 51 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                     for (int i = 0; i < indexprocess.Count; i++)
                    {
                        var local_i = i;

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<Blazorise.TableRow>(68);
                                    __builder7.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<Blazorise.TableRowHeader>(70);
                                        __builder8.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<Blazorise.Button>(72);
                                            __builder9.AddAttribute(73, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 55 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(74, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                                             () => @Edit(local_i)

#line default
#line hidden
#nullable disable
                                            )));
                                            __builder9.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(76, "Graph");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(77, "   \r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableRowCell>(78);
                                        __builder8.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(80, 
#nullable restore
#line 56 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                   indexprocess[local_i].Data

#line default
#line hidden
#nullable disable
                                            );
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(81, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableRowCell>(82);
                                        __builder8.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(84, 
#nullable restore
#line 57 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                   processname[local_i].Data

#line default
#line hidden
#nullable disable
                                            );
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(85, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableRowCell>(86);
                                        __builder8.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(88, 
#nullable restore
#line 58 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                   processmemory[local_i].Data

#line default
#line hidden
#nullable disable
                                            );
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(89, "\r\n                    ");
                                        __builder8.OpenComponent<Blazorise.TableRowCell>(90);
                                        __builder8.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(92, 
#nullable restore
#line 59 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                   processusage[local_i].Data

#line default
#line hidden
#nullable disable
                                            );
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 61 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                    }

#line default
#line hidden
#nullable disable
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n\r\n");
                __builder2.OpenComponent<Blazorise.Column>(94);
                __builder2.AddAttribute(95, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 70 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                    ColumnSize.IsFull.OnDesktop.IsHalf.OnWidescreen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Card>(97);
                    __builder3.AddAttribute(98, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 71 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                  Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Card>(100);
                        __builder4.AddAttribute(101, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 72 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                          Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.CardHeader>(103);
                            __builder5.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.CardTitle>(105);
                                __builder6.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(107, "Uso de Memória");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(108, "\r\n            ");
                            __builder5.OpenComponent<Blazorise.CardBody>(109);
                            __builder5.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.Charts.LineChart<LiveDataPoint>>(111);
                                __builder6.AddAttribute(112, "OptionsObject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 77 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                                                         memoryLineChartOptions

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Blazorise.Charts.Streaming.ChartStreaming<LiveDataPoint>>(114);
                                    __builder7.AddAttribute(115, "Options", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Charts.Streaming.ChartStreamingOptions>(
#nullable restore
#line 79 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                             new ChartStreamingOptions { Delay = 2000, FrameRate = 15 }

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(116, "Refreshed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.Charts.Streaming.ChartStreamingData<LiveDataPoint>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.Charts.Streaming.ChartStreamingData<LiveDataPoint>>(this, 
#nullable restore
#line 80 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                OnMemoryUsageLineRefreshed

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.AddComponentReferenceCapture(117, (__value) => {
#nullable restore
#line 77 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                  memoryLineChart = (Blazorise.Charts.LineChart<LiveDataPoint>)__value;

#line default
#line hidden
#nullable disable
                                }
                                );
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(118, "\r\n  \r\n            ");
                        __builder4.OpenComponent<Blazorise.Card>(119);
                        __builder4.AddAttribute(120, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 85 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                          Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.CardHeader>(122);
                            __builder5.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.CardTitle>(124);
                                __builder6.AddAttribute(125, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(126, "Uso CPU");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(127, "\r\n            ");
                            __builder5.OpenComponent<Blazorise.CardBody>(128);
                            __builder5.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.Charts.LineChart<LiveDataPoint>>(130);
                                __builder6.AddAttribute(131, "OptionsObject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 90 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                                                      cpuLineChartOptions

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Blazorise.Charts.Streaming.ChartStreaming<LiveDataPoint>>(133);
                                    __builder7.AddAttribute(134, "Options", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Charts.Streaming.ChartStreamingOptions>(
#nullable restore
#line 92 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                             new ChartStreamingOptions { Delay = 2000, FrameRate = 15 }

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(135, "Refreshed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.Charts.Streaming.ChartStreamingData<LiveDataPoint>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.Charts.Streaming.ChartStreamingData<LiveDataPoint>>(this, 
#nullable restore
#line 93 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                OnCPUUsageRefreshed

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.AddComponentReferenceCapture(136, (__value) => {
#nullable restore
#line 90 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                  cpuLineChart = (Blazorise.Charts.LineChart<LiveDataPoint>)__value;

#line default
#line hidden
#nullable disable
                                }
                                );
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenComponent<Blazorise.Row>(137);
            __builder.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(139);
                __builder2.AddAttribute(140, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 102 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                     ColumnSize.IsFull.OnDesktop.IsHalf.OnWidescreen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Button>(142);
                    __builder3.AddAttribute(143, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 103 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                    async () => await drawStart()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(144, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 103 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                             Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(145, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ButtonType>(
#nullable restore
#line 103 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                                                  ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(147, "Processos ativos");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(148, "\r\n ");
                    __builder3.OpenComponent<Blazorise.Card>(149);
                    __builder3.AddAttribute(150, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 104 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
               Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(151, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Card>(152);
                        __builder4.AddAttribute(153, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 105 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                          Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.CardHeader>(155);
                            __builder5.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.CardTitle>(157);
                                __builder6.AddAttribute(158, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(159, "Processos Totais");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(160, "\r\n            ");
                            __builder5.OpenComponent<Blazorise.CardBody>(161);
                            __builder5.AddAttribute(162, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.Charts.LineChart<LiveDataPoint>>(163);
                                __builder6.AddAttribute(164, "OptionsObject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 110 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                                                    TotalLineChartOptions

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Blazorise.Charts.Streaming.ChartStreaming<LiveDataPoint>>(166);
                                    __builder7.AddAttribute(167, "Options", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Charts.Streaming.ChartStreamingOptions>(
#nullable restore
#line 112 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                             new ChartStreamingOptions { Delay = 2000, FrameRate = 15 }

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(168, "Refreshed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.Charts.Streaming.ChartStreamingData<LiveDataPoint>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.Charts.Streaming.ChartStreamingData<LiveDataPoint>>(this, 
#nullable restore
#line 113 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                                OnTotalRefresh

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.AddComponentReferenceCapture(169, (__value) => {
#nullable restore
#line 110 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"
                                  totalChart = (Blazorise.Charts.LineChart<LiveDataPoint>)__value;

#line default
#line hidden
#nullable disable
                                }
                                );
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 120 "/home/bruno/SNMPSERVER/Pages/Testpage.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.SNMPSERVER.Pages.Testpage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
