﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Resources
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WindowsApplication1.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend Shared ReadOnly Property countries() As String
            Get
                Return ResourceManager.GetString("countries", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Afghanistan  
        '''Albania  
        '''Algeria  
        '''Andorra  
        '''Angola  
        '''Antarctica  
        '''Antigua and Barbuda  
        '''Argentina  
        '''Armenia  
        '''Aruba  
        '''Australia  
        '''Austria  
        '''Azerbaijan  
        '''Bahamas  
        '''Bahrain  
        '''Bangladesh  
        '''Barbados  
        '''Belarus  
        '''Belgium  
        '''Belize  
        '''Benin  
        '''Bhutan  
        '''Bolivia  
        '''Bosnia and Herzegovina  
        '''Botswana  
        '''Brazil  
        '''Brunei  
        '''Bulgaria  
        '''Burkina Faso  
        '''Burundi  
        '''Cambodia  
        '''Cameroon  
        '''Canada  
        '''Canary Islands  
        '''Cape Verde Islands  
        '''Cayman islands  
        '''Central African Republic  
        '''Chad  
        '''Chile  
        '''Ch [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property countries1() As String
            Get
                Return ResourceManager.GetString("countries1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend Shared ReadOnly Property usr_jpg() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("usr_jpg", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Class
End Namespace
