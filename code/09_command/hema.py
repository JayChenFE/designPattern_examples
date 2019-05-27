from abc import ABCMeta, abstractmethod

# 引入ABCMeta和abstractmethod来定义抽象类和抽象方法


class Chef():
    "厨师"

    def steamFood(self, originalMaterial):
        print(originalMaterial + "清蒸中...")
        return "清蒸" + originalMaterial

    def stirFriedFood(self, originalMaterial):
        print(originalMaterial + "爆炒中...")
        return "香辣炒" + originalMaterial


class Order(metaclass=ABCMeta):
    "订单"

    def __init__(self, name, originalMaterial):
        self._chef = Chef()
        self._name = name
        self._originalMaterial = originalMaterial

    def getDisplayName(self):
        return self._name + self._originalMaterial

    @abstractmethod
    def processingOrder(self):
        pass


class SteamedOrder(Order):
    "清蒸"

    def __init__(self, originalMaterial):
        super().__init__("清蒸", originalMaterial)

    def processingOrder(self):
        if (self._chef is not None):
            return self._chef.steamFood(self._originalMaterial)
        return ""


class SpicyOrder(Order):
    "香辣炒"

    def __init__(self, originalMaterial):
        super().__init__("香辣炒", originalMaterial)

    def processingOrder(self):
        if (self._chef is not None):
            return self._chef.stirFriedFood(self._originalMaterial)
        return ""


class Waiter:
    "服务员"

    def __init__(self, name):
        self.__name = name
        self.__order = None

    def receiveOrder(self, order):
        self.__order = order
        print("服务员" + self.__name + "：您的 " + order.getDisplayName() +
              " 订单已经收到,请耐心等待")

    def placeOrder(self):
        food = self.__order.processingOrder()
        print("服务员" + self.__name + "：您的餐 " + food + " 已经准备好，请您慢用!")


def testOrder():
    waiter = Waiter("Anna")
    steamedOrder = SteamedOrder("大闸蟹")
    print("客户David：我要一份" + steamedOrder.getDisplayName())
    waiter.receiveOrder(steamedOrder)
    waiter.placeOrder()
    print()

    spicyOrder = SpicyOrder("大闸蟹")
    print("客户Tony：我要一份" + steamedOrder.getDisplayName())
    waiter.receiveOrder(spicyOrder)
    waiter.placeOrder()


testOrder()
