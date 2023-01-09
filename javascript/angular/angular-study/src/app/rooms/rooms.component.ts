import { Person } from './persons';
import { Component } from '@angular/core';

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.scss'],
})
export class RoomsComponent {
  persons: Person[] = []
  increment(name: string) {
    const person = this.persons.find((x) => x.name == name);
    if (!person) return;
    person.count += 1;
  }
}
