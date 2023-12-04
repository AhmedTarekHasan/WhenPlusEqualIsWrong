<link rel="canonical" href="https://levelup.gitconnected.com/when-using-is-not-good-in-net-c-d4e6bfd5c644?sk=27bf9601792ef7b4447fd860eb194441" />

# When using += Is Not Good In .NET C#
### A case where blindly using += in .NET C# would drive you crazy.

<p align="center">
  <!--<img src="https://miro.medium.com/v2/resize:fit:1400/format:webp/1*v5MgAVZJtSyCOTnkwvQyKA.png">-->
</p>

<br/>

<p>
The main goal of this article is to demonstrate how a simple detail in our code could cause huge problems which are so hard to diagnose and troubleshoot.
</p>

<br/>

<p>
As an example, we would use the += operator.
</p>

<br/>

<p>
Have you ever imagined that blindly using the += operator could drive you crazy?
</p>

<br/>

<p>
In this article, I would show you how this could happen and how to fix it.
</p>

<br/>

If you are interested into reading more about this topic, you can read [the rest of the article][Article]. 

<br/>

## If you want to support me:
▶ Subscribe to Medium using [my referral link][Membership]<br/>
▶ Subscribe to [Medium Newsletter][Subscribe]<br/>
▶ Subscribe to [LinkedIn Newsletter][Newsletter]<br/>
▶ Follow me on [Medium][Blog]<br/>
▶ Follow me on [Twitter][Twitter]<br/>
▶ Follow me on [LinkedIn][LinkedIn]

<br/>

## Authors:
* [Ahmed Tarek Hasan]


[Ahmed Tarek Hasan]: https://medium.com/@eng_ahmed.tarek
[Blog]: https://medium.com/@eng_ahmed.tarek
[Membership]: https://medium.com/@eng_ahmed.tarek/membership
[Subscribe]: https://medium.com/subscribe/@eng_ahmed.tarek
[Twitter]: https://twitter.com/AhmedTarekHasa1
[LinkedIn]: https://www.linkedin.com/in/atarekhasan/
[Friend Links]: https://www.linkedin.com/feed/update/urn:li:activity:6866082670108143616/
[Newsletter]: https://www.linkedin.com/newsletters/development-simply-put-6866647119655247872/
[Article]: https://levelup.gitconnected.com/when-using-is-not-good-in-net-c-d4e6bfd5c644?sk=27bf9601792ef7b4447fd860eb194441