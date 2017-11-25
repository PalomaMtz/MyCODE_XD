<%@ Page Title="Gantt Chart Tutorial Project" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="DayPilot" Namespace="DayPilot.Web.Ui" TagPrefix="DayPilot" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent"></asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<div class="note">
</div>

        <DayPilot:DayPilotScheduler
            ID="DayPilotScheduler1" 
            runat="server" 
            DataEndField="TaskEnd"
            DataStartField="TaskStart" 
            DataTextField="TaskName" 
            DataValueField="TaskId" 
            DataResourceField="TaskId"
            Days="7"
            CellDuration="1440"
            EventMoveHandling="CallBack"
            ContextMenuID="DayPilotMenu1" 
            OnEventMenuClick="DayPilotCalendar1_EventMenuClick"
            EventResizeHandling="CallBack" 
            OnEventResize="DayPilotCalendar1_EventResize"
            OnEventMove="DayPilotCalendar1_EventMove"
            TimeRangeSelectedJavaScript="timeRangeSelected(start, end, resource);"
            TimeRangeSelectedHandling="JavaScript"
            EventClickHandling="JavaScript" 
            EventClickJavaScript="eventClick(e);"
            ClientObjectName="dp" 
            EventDeleteHandling="JavaScript" 
            OnEventDelete="DayPilotCalendar1_EventDelete"
            OnCommand="DayPilotCalendar1_Command"
            ShowEventStartEnd="false"
            OnBeforeEventRender="DayPilotCalendar1_BeforeEventRender"
            EventHeight="25"
            Width="100%"
            AfterRenderJavaScript="afterRender();"
            CssOnly="true"
            CssClassPrefix="scheduler_green"
            HourNameBackColor="#F0F0F0" 
            onbeforecellrender="DayPilotScheduler1_BeforeCellRender"
            OnBeforeTimeHeaderRender="DayPilotScheduler1_BeforeTimeHeaderRender"
            RowHeaderWidth="120"
            RowHeaderWidthAutoFit="true"
            DurationBarVisible="true"
            HeaderHeight="20"
            CellWidth="25" 
            BubbleID="BubbleEvent"
            ViewType="Resources"
            ShowToolTip="false"
        />

        <DayPilot:DayPilotMenu ID="DayPilotMenu1" runat="server" CssClassPrefix="menu_default_" >
            <DayPilot:MenuItem Text="Edit..." Action="JavaScript" JavaScript="eventClick(e);"></DayPilot:MenuItem>
            <DayPilot:MenuItem Text="-" Action="NavigateUrl"></DayPilot:MenuItem>
            <DayPilot:MenuItem Text="Delete" Action="JavaScript" JavaScript=" if (confirm('Do you really want to delete this task?')) dp.eventMenuClickCallBack(e, 'Delete');"></DayPilot:MenuItem>
        </DayPilot:DayPilotMenu>

        <DayPilot:DayPilotBubble 
            ID="BubbleEvent" 
            runat="server" 
            CssOnly="true" 
            CssClassPrefix="bubble_default"
            ShowAfter="100"
            >
        </DayPilot:DayPilotBubble>

</asp:Content>
