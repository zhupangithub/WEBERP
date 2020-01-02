var viewModel = function () {
    var self = this;
    this.grid = {
        size: { w: 239, h: 40 },
        url: "/api/erp/material",
        queryParams: ko.observable(),
        pagination: true
    };
    this.gridEdit = new com.editGridViewModel(this.grid);
    this.grid.onClickRow = self.gridEdit.begin;
    this.grid.OnAfterCreateEditor = function (edt) {
    };

    this.CodeType = ko.observable();
    this.CodeType.subscribe(function (value) {
        self.grid.queryParams({ MaterialType: value });
    });

    this.refreshClick = function () {
        window.location.reload();
    };
    this.addClick = function () {
        self.gridEdit.addnew("");
    };
    this.editClick = function () {
        var row = self.grid.treegrid('getSelected');
        self.gridEdit.begin(row);
    };
    this.deleteClick = self.gridEdit.deleterow;
    this.saveClick = function () {
        self.gridEdit.ended();
        var post = {list:self.gridEdit.getChanges()};
        if (self.gridEdit.isChangedAndValid()) {
            com.ajax({
                url: '/api/erp/material/edit',
                data: ko.toJSON(post),
                success: function (d) {
                    com.message('success', '保存成功！');
                    self.gridEdit.accept();
                }
            });
        }
    };
};