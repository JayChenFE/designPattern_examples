学习设计模式需要的UML类图知识

# 类

类是一组具有相同属性、操作、关系和语义的对象描述，一个类可是实现一个或者多个接口

![](https://raw.githubusercontent.com/JayChenFE/pic/master/20190503160656.png)

- UML预设了四种可见性，分别为

  - 公开(public)

  - 私有(private)

  - 保护(protected)

  - 包(package)

     减号(-)为私有可见性，加号(+)为公开可见性。可见，上图中的类图所有都为public

## 类之间的关系

关系是事物之间的联系，在面向对象的建模中，有三种重要的关系是依赖、泛化、关联。

----

- 依赖，`Dependency`
  - `依赖关系`: 是一种**使用关系**,即一个类的实现需要另一个类的协助,所以要尽量不使用双向互相依赖.
  - `代码表现`: 局部变量,方法的参数或者对静态方法的调用.`箭头指向` :带箭头的虚线,指向被使用者. 

  ![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/006.png) 

  - 依赖关系在.net语言中体现为 **局部变量**、**方法的参数**或者**对静态方法的调用**，如工具类，现实生活中人与锤子。

    ![](https://raw.githubusercontent.com/JayChenFE/pic/master/20190503161245.png)

----

- 泛化，`Generalization`
  - `泛化关系`:是一种继承关系,表示一般与特殊的关系,它指定了子类如何特化父类的所有特征和行为.例如:老虎是动物的 一种,既有老虎的特性也有动物的共性
  - `箭头指向`:带**三角箭头**的实线,**箭头指向父类 **

  ![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/001.png)

----

- 实现，`Realization`

  - `实现关系`:是一种类与接口的关系,表示类是接口的所有特征和行为的实线 
  - `箭头指向`: 带**三角箭头**的虚线,**箭头指向接口**

  ![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/002.png)

----

- 组合，`Composition`

  - `组合关系`: 是整体与部分的关系,但**部分不能离开整体而单独存在**.如公司和部门就是整体和部分的关系,没有公司就不   存在部门.

    组合关系是关联关系的一种,是比聚合还要强的关系,它要求普通的聚合关系中代表整体的对象负责代表部分的对象的生 命周期.

  - `代码体现` :成员变量

  - `箭头指向` :带**实心菱形**的实线,**菱形指向整体**

  ![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/003.png)

----

- 聚合，`Aggregation`

  - `聚合关系`: 是整体与部分的关系,且**部分可以离开整体而单独存在** .如车和轮胎是整体和部分的关系,轮胎离开车仍然可以存在.

    聚合关系是关联关系的一种,是强的关联关系;关联和聚合语法上无法区分,必须考察具体的逻辑关系.

  - `代码体现` :成员变量

  - `箭头指向` :带**空心菱形**的实线,**菱形指向整体**

  ![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/004.png)

----

- 关联，`Association`

  - `关联关系`:是一种拥有关系,它使一个类知道另一个类的属性和方法;如:老师与学生,丈夫与妻子.

    关联可以是双向的,也可以是单向的.双向的关联可以有两个箭头或者没有箭头,单向的关联有一个箭头

  - `代码体现`:成员变量 

  - `箭头指向`:

  ![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/005.png)

----

![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/007.png) 

