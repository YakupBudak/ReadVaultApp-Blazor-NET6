# Overview
*The Literature Web App **should** be a modern, user-friendly application that enables users to 
store a variety of literature formats and access them from any internet-enabled device with a browser.*

![](https://img.shields.io/github/issues/pandao/editor.md.svg)

## Base usage
- Comprehensive literature management
- Store and manage novels, teaching materials, PDFs and other literary formats.
- Customise fonts and paper colours to tailor the reading experience to your personal preferences.
- Platform-independent access

#### Target group
This application is aimed at readers, students, teachers and anyone who wants to efficiently collect and manage literature content.

```
flow
st=>start: ReadVault
op=>operation: Choose your reading
cond=>condition: found yet?
e=>end: happy reading

st->op->cond
cond(yes)->e
cond(no)->op
```
