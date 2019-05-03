# PlantUML类图表示

|  名称  | 英文               |   符号   |
| :--: | :--------------- | :----: |
|  泛化  | `Generalization` | `<|--` |
|  关联  | `Association`    | `<--`  |
|  组合  | `Composition`    | `*--`  |
|  实现  | `Realization`    | `<|..` |
|  依赖  | `Dependency`     | `<..`  |

## 2
假如文件名称为： bobAlice.uml
使用命令生成图

　　1、生成png图片

　　java -jar WORKM/ProgramSelf/PlantUML/plantuml.jar bobAlice.uml

　　2、生成svg图片

　　java -jar WORKM/ProgramSelf/PlantUML/plantuml.jar -tsvg bobAlice.uml
## 使用`PlantUML`画01中的例子

01

```js
@startuml

Class11 <|.. Class12 实现
Class13 <.. Class14  依赖
Class15 *.. Class16  组合
Class17 o.. Class18  聚合
Class19 .. Class20 

@enduml
```

![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/wsd/sample01.png)

02

![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/010.png)

03

```
@startuml
class Dummy {
    -field1
    #field2
    ~method1()
    +method2()
}
@enduml
```

![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/009.png)

04

组合和聚合也是带着耦合关系的，雁群就强耦合大雁，所以是箭尾，鸟强耦合翅膀，所以是箭尾

```
@startuml 动物
class 动物 {
    +有生命
    +新陈代谢(生命 水)
    +繁殖()
}
class 鸟{
    +翅膀
    +下蛋()
}
interface 飞翔{
    +飞()
}
class 大雁{
    +下蛋()
    +飞翔()
}
class 鸭{
    +下蛋()
}
class 企鹅{
    + 下蛋()
}

class 雁群{
    +V型飞行()
    +一型飞行()
}
class 唐老鸭{
    +讲话()
}

水 <. 动物
动物 .>空气
动物 <|-- 鸟
鸟 <|-- 大雁
鸟 <|-- 鸭
鸟 <|-- 企鹅
飞翔 <|. 大雁
大雁 -o 雁群
鸭--唐老鸭
企鹅 -> 气候 
@enduml
```

![](https://raw.githubusercontent.com/JayChenFE/pic/master/design_pattern/011.png)