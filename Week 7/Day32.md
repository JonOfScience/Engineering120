# Day 32 - 09/08/2022 - Web Testing

Where is the logic?
- If it is in the API then test there


Selenium tests are slow, harder to write, harder to maintain and brittle
*"You only get one (Selenium Test)"* - Daniel Webb


Understanding how to write them and understanding the challenges of using them
- Knowing how to articulate strategy on how it could be "better" by referring to the drawbacks


What is the most efficient way to test what I am trying to test?
- Too many testers test things at the UI layer rather than testing the functionality by understanding the internal structure

*"I've seen Selenium packs that take hours to run. Do you want to wait that long to find out if you broken something?"* - DW
- 15 minutes for tests run AND deployment

*"It is very easy to get drawn into the engineering, and forgetting to actually test anything."* - DW

*"If you take too much of a methodical engineering approach then you might be coming at it from the same direction as the person who built it. We should coming from another direction."* - DW


BOOK: "Perfect Software and other illusions about testing"
https://www.pdfdrive.com/perfect-software-and-other-illusions-about-testing-e199788982.html

Quality Gates thursday - Interview Preparedness
- Dan
- Martin & Nish
- Kieran(?)

Practice 
- Different types of interviews (team fit - about me, technical interview, both)
- Keep technical information fresh
- (Book helps put it all together - Framework - Especially Chapter 1 - "Why do we bother testing?")
- Describe yourself and give an account of yourself

- Being able to describe what a tester is, what an SDET is, in a way that shows you are passionate about it will be useful for the rest of your career

- Technical stuff
- Why are you here? Why do you want to do this?
- Be able to tell good stories

https://flukeout.github.io

## HTML

Page type 
```html
<!DOCTYPE html>
```
Head tag
- Meta declarations - tells other computers or search engines technical information about the document

Body tag
- What we actually see on the page

https://www.w3schools.com/html/html5_semantic_elements.asp


### Forms
```html
<input id="text" name="q" type="text" value="Manchester">
```

add "?q=Manchester" to the address of the page
- `id` identifier, useful in testing (ID EVERY SINGLE ELEMENT)
- `name` specifies the query keyword
- `value` default value

## CSS

Specify styles in the head and it then applies to the whole document

Best practice to have an external CSS file that can references 

- Browser Default applied first
- Then Head Style
- The Inline Style

<hr>
Each style overwrites the one before if it applies to the same element
<hr>

**Selectors** specify which elements styles will be applied to e.g. `body`, `h1`

Can import fonts
https://fonts.google.com/
- Import font into HTML head
- Add usage into CSS

Can also target specific element classes (`.`)

```html
.box-1{
}
```

And elements within those classes

```html
.box-1 h4{
}
```

### The Box Model

Margin (outer) - The parent element - Give the effect of increasing the content size of the parent element (AROUND the border)
Border / Ouline (next in) - Can colour the border - Quite small
Padding (next in) - Gives the effect of increasing the content layer
Content

***

Ids are unique identifiers for a particular elements
classes can be used by multiple elements

***

Flex containers

***

## Bootstrap
https://www.w3schools.com/whatis/whatis_bootstrap.asp
https://getbootstrap.com/docs/5.2/getting-started/introduction/
https://getbootstrap.com/docs/5.2/components/buttons/

