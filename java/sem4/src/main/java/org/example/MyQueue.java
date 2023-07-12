package org.example;

import java.util.LinkedList;

/*
    Task 2
 */

class MyQueue {
    private LinkedList<Object> elements = new LinkedList();

    public MyQueue() { }
    public MyQueue(LinkedList<Object> linkedList) {
        this.elements = linkedList;
    }

    public void enqueue(Object element){
        elements.addLast(element);
    }

    public Object dequeue(){
        return elements.pollFirst();
    }

    public Object first(){
        return elements.peekFirst();
    }

}