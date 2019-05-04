$.ajax('http://xxx.com?login', function (data) {
    login.trigger('loginSucc', data);
});

var header = (function () { // header模块
    login.listen('loginSucc', function () {
        header.setAvatar(data.avatar);
    })
    return setAvatar: function(avatar) {
        console.log('设置header模块的头像')
    }
})();


var nav = (function () { // nav模块
    login.listen('loginSucc', function () {
        nav.setAvatar(data.avatar);
    })
    return setAvatar: function(avatar) {
        console.log('设置nav模块的头像')
    }
})();

var address = (function () { //address模块
    login.listen('loginSucc', function () {
        address.refresh();
    })
    return refresh: function() {
        console.log('刷新收货地址列表')
    }
})();
