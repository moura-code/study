
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.ListIterator;

public class JULinkedList <T> implements List {



    private class Node{
        Object data;
        Node next;
        Node(Object data){
            this.data = data;
            next=null;
        }

    }
    Node head;






    @Override
    public int size() {
        // do awhile loop until the final of the list increasing the count variable
      if (head == null){
          return 0;
      }
      Node temp = head;
      int count = 0;
      while (temp!=null){
          count++;
          temp = temp.next;
      }
      return count;
    }
    @Override
    public boolean isEmpty() {
        //check if the head is null and if its true the list is empty
        if(head==null){
            return true;
        }

        return false;
    }

    @Override
    public boolean contains(Object o) {
        if(head==null){
            return false;
        }
        Node current = head;
        while(current != null && !current.data.equals(o)){

            current = current.next;
        }
        if(current.data.equals(o)){
            return true;
        }
        return false;
    }

    @Override
    public Iterator <T>iterator() {
        if(head.next != null){
            return (Iterator<T>) head.next;
        }

        return null;
    }

    @Override
    public Object[] toArray() {
        return new Object[0];
    }

    @Override
    public boolean add(Object o) {
        // go to final of the list and add the element there
        Node toinsert = new Node(o);
        if(head ==null){
            head = toinsert;
            return true;
        }
        Node temp = head;
        while (temp.next!=null){
            temp=temp.next;
        }
        temp.next= toinsert;
        return true;
    }

    @Override
    public boolean remove(Object o) {
        //do while loop until find the element and then remove it connecting the previous node with the next node
        Node current = head;
        Node temp = null;
        if(o == head.data){
            head = current.next;
            return true;
        }

        while(current != null && !current.data.equals(o)){
            temp = current;
            current = current.next;
        }

        if(current == null){
            return true;
        }

        temp.next = current.next;
        return false;
    }




    @Override
    public boolean addAll(Collection c) {
        return false;
    }

    @Override
    public boolean addAll(int index, Collection c) {
        return false;
    }

    @Override
    public void clear() {
        //make the head null to clear the list
        head = null;

    }

    @Override
    public Object get(int index) {
        // using the count until its equal to index then return the data of the node
        if (head == null){
            return null;
        }


        Node temp = head;


        if(index < 0 || index >=size()){
            return null;
        }else if(index == 0){


            return head.data;
        }else {

            Node previous = head;
            int count = 1;
            while(count < index - 1){
                previous = previous.next;
                count++;
            }

            Node current = previous.next;

            return current.data;
        }
    }

    @Override
    public Object set(int index, Object element) {
        // go to the index and replace the current object with a new one that has the new object
        Node node = head;

        if(index == 1){
            node.next = head;
            head = node;
        } else {
             Node previous = head;
            int count = 1; // position - 1

            while(count < index - 1){
                previous = previous.next;
                count++;
            }

            Node current = previous.next;
            previous.next = node;
            node.next = current;
        }

        return element;
    }

    @Override
    public void add(int index, Object element) {
        // go to the index of the list and then inset the element and make his next be the original next
        Node node = head;
        Node toinsert = new Node(element);
        if(index == 0){
            toinsert.next = head;
            head = toinsert;
        } else {
            Node previous = head;
            int count = 1; // position - 1

            while(count < index - 1){
                previous = previous.next;
                count++;
            }

            Node current = previous.next;
            previous.next = toinsert;
            toinsert.next=current;
            node.next = current;
        }


    }

    @Override
    public Object remove(int index) {
        // go to the index and connect the previous node with the next one
        // 1 -> 2 ->3
        //1 -> 3
        if (head == null){
            return null;
        }


        Node temp = head;


        if(index < 0 || index >=size()){
            return null;
        }else if(index == 0){

            head = head.next;
            temp.next = null;
            return temp;
        }else {

            Node previous = head;
            int count = 1;
            while(count < index - 1){
                previous = previous.next;
                count++;
            }

            Node current = previous.next;
            previous.next = current.next;
            return current.data;
        }
    }

    @Override
    public int indexOf(Object o) {
        //find the object with a while loop and then return the count
        if (head == null){
            return 0;
        }
        Node temp = head;
        int count = 0;
        if(temp.data == o){
            return 0;
        }
        while ((temp.next != null || temp.data!=o)){
            count++;
            temp = temp.next;
        }
        return count;


    }

    @Override
    public int lastIndexOf(Object o) {
        //find the last index of the object on the list
        // 1->2->2, return 3
        int index = -1;
        int size = size();
        int count = 0;

        Node current = head;

        for (int i = 0; i < size; i++) {
            Object indexValue = current.data;
            if (o == current.data) {index = count;}
            count++;
            current = current.next;
        }
        return index;

    }

    @Override
    public ListIterator listIterator() {
        return null;
    }

    @Override
    public ListIterator listIterator(int index) {
        return null;
    }

    @Override
    public List subList(int fromIndex, int toIndex) {

        return null;
    }

    @Override
    public boolean retainAll(Collection c) {
        return false;
    }

    @Override
    public boolean removeAll(Collection c) {
        return false;
    }

    @Override
    public boolean containsAll(Collection c) {
        return false;
    }

    @Override
    public Object[] toArray(Object[] a) {
        return new Object[0];
    }
}
