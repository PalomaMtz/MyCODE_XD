/* Event editing helpers - modal dialog */
function dialog() {
    var modal = new DayPilot.Modal();
    modal.top = 60;
    modal.width = 250;
    modal.height = 150;
    modal.opacity = 70;
    modal.border = "10px solid #d0d0d0";
    modal.closed = function () {
        if (this.result == "OK") {
            dp.commandCallBack('refresh');
        }
        dp.clearSelection();
    };
    return modal;
}

function timeRangeSelected(start, end, resource) {
    if (resource !== 'NEW') {
        dp.clearSelection();
        dp.message("Use the 'New Task' row");
        return;
    }

    var modal = dialog();
    var url = "New.aspx?start=" + start.toStringSortable() + "&end=" + end.toStringSortable();
    modal.showUrl(url);
}

function eventClick(e) {
    var modal = dialog();
    if (e.recurrent()) {
        modal.showUrl("Edit.aspx?id=" + e.recurrentMasterId());
    }
    else {
        modal.showUrl("Edit.aspx?id=" + e.value());
    }
}

function afterRender() {
}

