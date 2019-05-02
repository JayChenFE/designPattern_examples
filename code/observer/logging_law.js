login.succ(function(data) {

  header.setAvatar(data.avatar); //设置header模块的头像
  nav.setAvatar(data.avatar);//设置导航模块的头像
  message.refresh()//刷新消息列表
  cart.refresh()//刷新购物车列表

});
