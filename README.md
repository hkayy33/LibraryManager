# LibraryManager

#### This Application allows for a centralised approach to managing an online library system, where patrons can borrow or return books. Everything is kept updated.

## Application Structure
- The Program is ran from the ```program.cs``` file, located in the ```ProgramExecuter``` folder.
- The Library Management system is located in the ```Manager``` folder, where logic to manage books, patrons and query them are stored.
- The Book and Patron files are located in the ```Dependancies``` folder, posing as blueprints for actual books and users.

## Assumptions:
- As for now, its assumed that books do not exist in multiple qunantities, meaning the library only holds one book. However, there are no regulations stopping you from adding multiple books.

## Future Implmentations:
- Clearly display the quatity of books available
- Implement a function where the library Management system can query the books taken out by an individual.  
- Implement a return by feature

#### Enjoy using Library Manager