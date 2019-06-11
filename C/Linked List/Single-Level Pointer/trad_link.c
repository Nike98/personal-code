
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define TRUE 1
#define FALSE 0
typedef int BOOL;

typedef struct _thing
{
    char *item;
    struct _thing *next;
} THING;

THING *start = NULL;

// Create new list element of type THING from the supplied text string
THING *NewElement( char *text )
{
    THING *newp;
    newp = (THING *) malloc(sizeof(THING));
    newp->item = (char *) malloc(strlen(text) + 1);
    strcpy(newp->item, text);
    newp -> next = NULL;
    return newp;
}

// deletement: remove from list the first instance of an element
// containing a given text string
// Note!! delete requests for elements not in the list are silently ignored
THING *deletement(THING *head, char *text)
{
    THING *p, *prev;
    prev = NULL;
    for (p = head; p != NULL; p = p -> next){
        if (strcmp(text, p -> item) == 0){
            if (prev == NULL)
                head = p -> next;
            else
                prev -> next = p -> next;
            free(p -> item);    // Free off the String field
            free(p);            // Remove rest of THING
            return head;
        prev = p;
    }
}

// addfront: add new new THING to front of the list
// example usage: start = (addfront(start, newelement("burgers"));

THING *addfront (THING *head, THING *newp)
{
    newp -> next = head;
    return newp;
}

// addend: add new THING to the end of a list
// example usage: start = (addend(start, newelement("wine"));

THING *addend (THING *head, THING *newp)
{
    THING *p2;
    if (head == NULL)
        return newp;

    // Now find the end of the list
    for (p2 = head; p2 -> next != NULL; p2 = p2 -> next);

    p2 -> next = newp;
    return head;
}

// Add elements into the middle of a list of THINGS based on alphabetical order
// of the 'item' strings within the THING structures
THING *addmiddle (THING *head, THING *newp)
{
    BOOL found = FALSE;
    THING *p1, *p2;
    if (head == NULL){
        // special case
        printf(" Initial List was NULL\n");
        head = addfront(head, newp);
        return head;
    }

    // Main loop. Use p2 to remember previous p1
    p2 = p1 = head;
    while (!found){
        if (found = strcmp(p1 -> item, newp -> item) >= 1) {
            if (p1 == head){
                printf(" Adding at head\n");
                head = addfront(head, newp);
                return(head);
            }
            else{
                // general case - insert the item
                printf(" General case entered\n");
                p2 -> next = newp;
                newp -> next = p1;
                return head;
            }
        }

        // Match not found before end of list so insert at end
        if (p1 -> next == NULL){
            head = addend(head, newp);
            return (head);
        }

        // Go round while loop one more time
        p2 = p1; p1 = p1 -> next;
    } // end of while
}

// This routine uses pointer-to-pointer techniques
void printlist(THING **head)
{
    THING **tracer = head;
    while ((*tracer) != NULL){
        printf(" %s \n", (*tracer) -> item);
        tracer = &(*tracer)->next;
    }
}

int main (int argc, char **argv)
{
    start = addmiddle(start, NewElement("Chips"));
    start = addmiddle(start, NewElement("Wine"));
    start = addmiddle(start, NewElement("Beer"));
    start = addmiddle(start, NewElement("Pizza"));
	start = addmiddle(start, NewElement("Zucchini"));
	start = addmiddle(start, NewElement("Burgers"));
	start = addmiddle(start, NewElement("Burgers"));
	start = addmiddle(start, NewElement("Slaw"));

	printf("\n INITIAL LIST \n");
	printlist(&start);

	deletement(start, "Pizza");
	deletement(start, "Zucchini");
	deletement(start, "Burgers");

	printf("\n ALTERED LIST\n");
	printlist(&start);

	return 0;
}
