# Code Librarian
This program stores and organizes your code snippets in any programming language with its easy to use features. I originally built this because I didn’t like the ones I saw on the Internet, so I decided to make my own. The program is very useful for people who are starting out in programming and for advanced programmers who need a place to store their snippets for reuse. The program was also designed to work with teams and with third-party code where crediting information will need to be saved.

![Program Screenshot](https://github.com/StevenJDH/Code-Librarian/raw/master/code_librarian3-ss.jpg "Screenshot")
<br />NOTE: This is a screenshot of version 3. Version 4 will have some minor design changes that were very much needed.

Releases: [https://github.com/StevenJDH/Code-Librarian/releases](https://github.com/StevenJDH/Code-Librarian/releases)

Changelog: [https://github.com/StevenJDH/Code-Librarian/wiki/Changelog](https://github.com/StevenJDH/Code-Librarian/wiki/Changelog)

Bugs and Limitations: [https://github.com/StevenJDH/Code-Librarian/wiki/Bugs-and-Limitations](https://github.com/StevenJDH/Code-Librarian/wiki/Bugs-and-Limitations)

## Features
* Easily add, update, and delete your snippets code records.
* Manage authors, contact info, and languages for those records.
* A language filter to filter out everything except what you want to see.
* A built-in search engine to find your code records fast. Search by keywords, Language, Author, or all three.
* Keyboard shortcuts for those who like them.
* Open other people's databases for view or editing.
* You can choose either to have the list panel placed on the left or on the right side of the program for comfort.
* Displayed at bottom is the amount of snippet code records contained in the database.
* Create backups of your database.
* Manager your personal database separately from everyone else in a multi-user environment.

## TODO
* Still performing the massive rewrite of Code Librarian for version 4.0, so there is still a lot to do. The good news is that the horrible, messy code I designed from when I was about 13 is gone. New users should treat version 3 as a demo for now, since unless requested, there will be no import feature to migrate previous databases in version 4. This is mostly due to the fact that Access databases can have issues, and because my original database design didn't use a proper structure.

## The database and EF6
Code Librarian will now use an SQLite database for its portability along with Entity Framework 6x using a partial Database First Approach since currently there are some limitations with SQLite. Below is an ERD of the database design for reference. 

![ERD](https://github.com/StevenJDH/Code-Librarian/raw/master/ERD_Diagram.png "ERD Diagram")

## Do you have any questions?
Many commonly asked questions are answered in the FAQ:
[https://github.com/StevenJDH/Code-Librarian/wiki/FAQ](https://github.com/StevenJDH/Code-Librarian/wiki/FAQ)

## Need to contact me?
I can be reached here directly at [https://21.co/stevenjdh](https://21.co/stevenjdh "Contact Page")

## Want to show your support?

|Method       | Address                                                                                                    |
|------------:|:-----------------------------------------------------------------------------------------------------------|
|PayPal:      | [https://www.paypal.me/stevenjdh](https://www.paypal.me/stevenjdh "Steven's Paypal Page")                  |
|Bitcoin:     | 3GyeQvN6imXEHVcdwrZwKHLZNGdnXeDfw2                                                                         |
|Litecoin:    | MAJtR4ccdyUQtiiBpg9PwF2AZ6Xbk5ioLm                                                                         |
|Ethereum:    | 0xa62b53c1d49f9C481e20E5675fbffDab2Fcda82E                                                                 |
|Dash:        | Xw5bDL93fFNHe9FAGHV4hjoGfDpfwsqAAj                                                                         |
|Zcash:       | t1a2Kr3jFv8WksgPBcMZFwiYM8Hn5QCMAs5                                                                        |
|PIVX:        | DQq2qeny1TveZDcZFWwQVGdKchFGtzeieU                                                                         |
|Ripple:      | rLHzPsX6oXkzU2qL12kHCH8G8cnZv1rBJh<br />Destination Tag: 2357564055                                        |
|Monero:      | 4GdoN7NCTi8a5gZug7PrwZNKjvHFmKeV11L6pNJPgj5QNEHsN6eeX3D<br />&#8618;aAQFwZ1ufD4LYCZKArktt113W7QjWvQ7CWDXrwM8yCGgEdhV3Wt|


// Steven Jenkins De Haro ("StevenJDH" on GitHub)
