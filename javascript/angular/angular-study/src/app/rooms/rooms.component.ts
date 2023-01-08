import { Component } from '@angular/core';

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.scss'],
})
export class RoomsComponent {
  persons = ['joao', 'pedro', 'mock', 'felipe'].map((nome) =>
    this.createPerson(nome)
  );

  createPerson(name: string) {
    return { name, count: 0 };
  }
  increment(name: string) {
    const person = this.persons.find((x) => x.name == name);
    if (!person) {
      return;
    }
    person.count += 1;
  }
}
